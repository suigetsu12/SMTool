using SM.Models;
using SM.Models.Configuration;
using SM.Models.Storage;
using SM.Services;
using SM.Shared.Constants;
using SM.Shared.Extensions;
using SM.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.Forms.Forms.Settings.Data
{
    public partial class frmDataPublish : Form
    {
        private List<PublishItemModel> items = new List<PublishItemModel>();
        private string _publishPath = string.Empty;
        private StringRenderService _stringRenderService = new StringRenderService();
        public frmDataPublish()
        {
            _publishPath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Publish);
            LoadData();
            InitializeComponent();
            BindData();
        }

        private void LoadData()
        {
            string jsonPublishString = FileHelper.ReadFile(_publishPath);
            if (jsonPublishString.NotNullOrEmpty())
            {
                items = JsonHelper.Deserialize<List<PublishItemModel>>(jsonPublishString);
            }
        }

        private void BindData()
        {
            if (items.NotNullOrEmpty())
            {
                var list = new BindingList<PublishItemModel>(items);
                dgvPublish.DataSource = list;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CleanFields();
            btnUpdate.Enabled = false;
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtFileName.Text = "";
            txtContent.Text = "";
            txtProjectFolder.Text = "";
            txtProjectParam.Text = "";
            txtOutputFolder.Text = "";
            txtOutputParam.Text = "";
            lbIdSelected.Text = "";
            rdFeature.Checked = false;
            rdFunction.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = Validation();
            if (message.NotNullOrEmpty())
            {
                MessageBox.Show(message);
                return;
            }
            var lastOrder = items.Max(m => m.Order);
            PublishItemModel newItem = new PublishItemModel
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                FileName = txtFileName.Text.Trim(),
                ProjectFolder = txtProjectFolder.Text.Trim(),
                ProjectParam = txtProjectParam.Text.Trim(),
                OutputFolder = txtOutputFolder.Text.Trim(),
                OutputParam = txtOutputParam.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                PublishType = rdFeature.Checked ? Shared.Enums.PublishType.Feature : Shared.Enums.PublishType.Function,
                Order = lastOrder + 1
            };
            items.Add(newItem);
            var jsonData = JsonHelper.Serializer(items);
            var result = FileHelper.WriteFile(_publishPath, jsonData);
            if (result)
            {
                var resultWrite = WriteContent(newItem.FileName);
                if (resultWrite)
                {
                    Success(newItem.PublishType);
                }
                else
                {
                    MessageBox.Show(MessageConstans.Failed);
                }
            }
            else
            {
                MessageBox.Show(MessageConstans.Failed);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = Validation(true);
            if (message.NotNullOrEmpty())
            {
                MessageBox.Show(message);
                return;
            }
            var item = items.FirstOrDefault(m => m.Id == new Guid(lbIdSelected.Text));
            if (item != null)
            {
                bool hasChangeFileName = false;
                string newPathFile = string.Empty;
                string oldPathFile = string.Empty;
                if (item.FileName != txtFileName.Text.Trim())
                {
                    hasChangeFileName = true;
                    oldPathFile = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Publish, item.FileName);
                    newPathFile = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Publish, txtFileName.Text.Trim());
                }
                item.Name = txtName.Text.Trim();
                item.FileName = txtFileName.Text.Trim();
                item.ProjectFolder = txtProjectFolder.Text.Trim();
                item.ProjectParam = txtProjectParam.Text.Trim();
                item.OutputFolder = txtOutputFolder.Text.Trim();
                item.OutputParam = txtOutputParam.Text.Trim();
                item.Description = txtDescription.Text.Trim();
                item.PublishType = rdFeature.Checked ? Shared.Enums.PublishType.Feature : Shared.Enums.PublishType.Function;
                var jsonData = JsonHelper.Serializer(items);
                var result = FileHelper.WriteFile(_publishPath, jsonData);
                if (!result)
                {
                    MessageBox.Show(MessageConstans.Failed);
                }
                else
                {
                    if (hasChangeFileName)
                    {
                        var resultRename = FileHelper.RenameFile(oldPathFile, newPathFile, txtContent.Text);
                        if (resultRename)
                        {
                            Success(item.PublishType);
                        }
                        else
                        {
                            MessageBox.Show(MessageConstans.Failed);
                        }
                    }
                    else
                    {
                        Success(item.PublishType);
                    }
                }
            }
        }

        private void Success(Shared.Enums.PublishType type)
        {
            BindData();
            MessageBox.Show(MessageConstans.Success);
            if (type == Shared.Enums.PublishType.Function)
                UpdateSourceCofig();
        }

        private string Validation(bool isUpdate = false)
        {
            if (isUpdate && !lbIdSelected.Text.NotNullOrEmpty())
                return MessageConstans.NoDataSelected;
            if (!txtFileName.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "file name");
            if (!txtName.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "name");
            if (!txtFileName.Text.EndsWith(".bat"))
                return MessageConstans.WrongFormatFile;
            if (!rdFeature.Checked && !rdFunction.Checked)
                return String.Format(MessageConstans.TheFieldEmpty, "publish type");
            if (rdFunction.Checked)
            {
                if (!txtProjectFolder.Text.NotNullOrEmpty())
                    return String.Format(MessageConstans.TheFieldEmpty, "project folder");
                if (!txtProjectParam.Text.NotNullOrEmpty())
                    return String.Format(MessageConstans.TheFieldEmpty, "project param");
                if (!txtOutputFolder.Text.NotNullOrEmpty())
                    return String.Format(MessageConstans.TheFieldEmpty, "output folder");
                if (!txtOutputParam.Text.NotNullOrEmpty())
                    return String.Format(MessageConstans.TheFieldEmpty, "output param");
            }

            var exist = items.FirstOrDefault(i => i.Name == txtName.Text.Trim() || i.FileName == txtFileName.Text.Trim());
            if (exist != null)
            {
                if (!isUpdate || (isUpdate && exist.Id != new Guid(lbIdSelected.Text)))
                    return MessageConstans.ItemAlreadyExist;
            }

            return string.Empty;
        }

        private void dgvPublish_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    var Id = (Guid)row.Cells["clId"].Value;
                    var item = items.FirstOrDefault(i => i.Id == Id);
                    if (item != null)
                    {
                        lbIdSelected.Text = Id.ToString();
                        txtName.Text = item.Name;
                        txtFileName.Text = item.FileName;
                        txtDescription.Text = item.Description;
                        txtProjectFolder.Text = item.ProjectFolder;
                        txtProjectParam.Text = item.ProjectParam;
                        txtOutputFolder.Text = item.OutputFolder;
                        txtOutputParam.Text = item.OutputParam;
                        if (item.PublishType == Shared.Enums.PublishType.Feature)
                        {
                            rdFeature.Checked = true;
                            rdFunction.Checked = false;
                        }
                        else
                        {
                            rdFeature.Checked = false;
                            rdFunction.Checked = true;
                        }
                        ReadContent(item.FileName);
                        btnUpdate.Enabled = true;
                    }
                }
            }
        }

        private void ReadContent(string filename)
        {
            var path = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Publish, filename);
            var stringData = FileHelper.ReadFile(path);
            txtContent.Text = stringData;
        }

        private bool WriteContent(string filename)
        {
            var path = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Publish, filename);
            return FileHelper.WriteFile(path, txtContent.Text);
        }

        private void ShowHideFuncNeedFields(bool isShow)
        {
            lbProjectFolder.Visible = isShow;
            lbProjectParam.Visible = isShow;
            lbOutputFolder.Visible = isShow;
            lbOutputParam.Visible = isShow;
            txtProjectFolder.Visible = isShow;
            txtProjectParam.Visible = isShow;
            txtOutputFolder.Visible = isShow;
            txtOutputParam.Visible = isShow;
        }

        private void rdFeature_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFuncNeedFields(false);
        }

        private void rdFunction_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFuncNeedFields(true);
        }

        private void UpdateSourceCofig()
        {
            var listFunctions = items.Where(i => i.PublishType == Shared.Enums.PublishType.Function).ToList();
            var listProject = listFunctions.Select(s => new SourceConfigItemModel
            {
                Folder = s.ProjectFolder,
                Param = s.ProjectParam
            }).ToList();
            var listOutput = listFunctions.Select(s => new SourceConfigItemModel
            {
                Folder = s.OutputFolder,
                Param = s.OutputParam
            }).ToList();
            var stringData = _stringRenderService.RenderSourceConfiguration(listProject, listOutput);
            var path = Path.Combine(Global.RootAppFolderPath, PathConstants.Bat_Source);
            FileHelper.WriteFile(path, stringData);
        }
    }
}

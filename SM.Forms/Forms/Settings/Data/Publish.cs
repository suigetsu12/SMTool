using SM.Models;
using SM.Models.Storage;
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
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtFileName.Text = "";
            txtContent.Text = "";
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
                    BindData();
                    MessageBox.Show(MessageConstans.Success);
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
                item.Description = txtDescription.Text.Trim();
                item.PublishType = rdFeature.Checked ? Shared.Enums.PublishType.Feature : Shared.Enums.PublishType.Function;
                var jsonData = JsonHelper.Serializer(items);
                var result = FileHelper.WriteFile(_publishPath, jsonData);
                if (result)
                {
                    if (hasChangeFileName)
                    {
                        var resultRename = FileHelper.RenameFile(oldPathFile, newPathFile, txtContent.Text);
                        if (resultRename)
                        {
                            BindData();
                            MessageBox.Show(MessageConstans.Success);
                        }
                        else
                        {
                            MessageBox.Show(MessageConstans.Failed);
                        }
                    }
                    else
                    {
                        BindData();
                        MessageBox.Show(MessageConstans.Success);
                    }
                }
                else
                {
                    MessageBox.Show(MessageConstans.Failed);
                }
            }
        }

        private string Validation(bool isUpdate = false)
        {
            if (isUpdate && !lbIdSelected.Text.NotNullOrEmpty())
                return MessageConstans.NoDataSelected;
            if (!txtName.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "name");
            if (!txtFileName.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "file name");
            if (!txtFileName.Text.EndsWith(".bat"))
                return MessageConstans.WrongFormatFile;
            if (!rdFeature.Checked && !rdFunction.Checked)
                return String.Format(MessageConstans.TheFieldEmpty, "publish type");

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
                        btnAdd.Visible = false;
                        btnUpdate.Visible = true;
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
    }
}

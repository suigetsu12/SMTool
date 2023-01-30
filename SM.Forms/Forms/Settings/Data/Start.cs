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
    public partial class frmDataStart : Form
    {
        private List<StartItemModel> items = new List<StartItemModel>();
        private List<BaseItemModel> features = new List<BaseItemModel>();
        private List<Guid> selectedFeatures = new List<Guid>();
        private string _startPath = string.Empty;
        private string _featurePath = string.Empty;
        public frmDataStart()
        {
            _startPath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Start);
            _featurePath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Feature);
            LoadData();
            LoadFeature();
            InitializeComponent();
            BindFeature();
            BindData();
        }

        private void LoadData()
        {
            string jsonStartString = FileHelper.ReadFile(_startPath);
            if (jsonStartString.NotNullOrEmpty())
            {
                items = JsonHelper.Deserialize<List<StartItemModel>>(jsonStartString);
            }
        }

        private void LoadFeature()
        {
            string jsonFeatureString = FileHelper.ReadFile(_featurePath);
            if (jsonFeatureString.NotNullOrEmpty())
            {
                features = JsonHelper.Deserialize<List<BaseItemModel>>(jsonFeatureString);
            }
        }

        private void BindFeature()
        {
            if (!features.IsNullOrEmpty())
            {
                pnFeature.Controls.Clear();
                int yPoint = 15;
                foreach (var feature in features)
                {
                    CheckBox cb = new CheckBox();
                    cb.Text = feature.Name;
                    cb.Width = 200;
                    cb.CheckedChanged += new EventHandler(this.CheckedChangeItem);
                    pnFeature.Controls.Add(cb);
                    cb.Location = new Point(15, yPoint);
                    yPoint += 30;
                }
            }
        }

        private void BindData()
        {
            if (items.NotNullOrEmpty())
            {
                var list = new BindingList<StartItemModel>(items);
                dgvStart.DataSource = list;
            }
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
            StartItemModel newItem = new StartItemModel
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                FileName = txtFileName.Text.Trim(),
                Features = selectedFeatures,
                Order = lastOrder + 1
            };
            items.Add(newItem);
            var jsonData = JsonHelper.Serializer(items);
            var result = FileHelper.WriteFile(_startPath, jsonData);
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

            var exist = items.FirstOrDefault(i => i.Name == txtName.Text.Trim() || i.FileName == txtFileName.Text.Trim());
            if (exist != null)
            {
                if (!isUpdate || (isUpdate && exist.Id != new Guid(lbIdSelected.Text)))
                    return MessageConstans.ItemAlreadyExist;
            }

            return string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CleanFields();
            btnUpdate.Enabled = false;
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtFileName.Text = "";
            txtContent.Text = "";
            selectedFeatures = new List<Guid>();
            foreach (Control cb in pnFeature.Controls)
            {
                if (cb is CheckBox)
                {
                    ((CheckBox)cb).Checked = false;
                }
            }
        }

        private void ReadContent(string filename)
        {
            var path = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Start, filename);
            var stringData = FileHelper.ReadFile(path);
            txtContent.Text = stringData;
        }

        private bool WriteContent(string filename)
        {
            var path = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Start, filename);
            return FileHelper.WriteFile(path, txtContent.Text);
        }

        private void dgvStart_SelectionChanged(object sender, EventArgs e)
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
                        selectedFeatures = item.Features;
                        var activeFeatures = features.Where(w => item.Features.Contains(w.Id)).ToList();
                        if (activeFeatures.NotNullOrEmpty())
                        {
                            foreach (Control cb in pnFeature.Controls)
                            {

                                if (cb is CheckBox)
                                {
                                    var exist = activeFeatures.FirstOrDefault(a => a.Name == cb.Text);
                                    if (exist != null)
                                        ((CheckBox)cb).Checked = true;
                                    else
                                        ((CheckBox)cb).Checked = false;
                                }
                            }
                        }

                        ReadContent(item.FileName);
                        btnUpdate.Enabled = true;
                    }
                }
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
                    oldPathFile = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Start, item.FileName);
                    newPathFile = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Start, txtFileName.Text.Trim());
                }
                item.Name = txtName.Text.Trim();
                item.FileName = txtFileName.Text.Trim();
                item.Features = selectedFeatures;
                var jsonData = JsonHelper.Serializer(items);
                var result = FileHelper.WriteFile(_startPath, jsonData);
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
            }
        }

        private void CheckedChangeItem(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            var item = items.FirstOrDefault(i => i.Name == cb?.Text);
            if (item != null)
            {
                if (cb != null && cb.Checked)
                {
                    selectedFeatures.Add(item.Id);
                }
                else
                {
                    selectedFeatures.Remove(item.Id);
                }
            }
        }
    }
}

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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.Forms.Forms.Settings.Data
{
    public partial class frmReplace : Form
    {
        private List<ReplaceItemModel> items = new List<ReplaceItemModel>();
        private string _replacePath = string.Empty;
        //true:replace value by key, false: replace new value by old value
        public frmReplace()
        {
            _replacePath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Replace);
            LoadData();
            InitializeComponent();
            BindData();
        }

        private void LoadData()
        {
            string jsonReplaceString = FileHelper.ReadFile(_replacePath);
            if (jsonReplaceString.NotNullOrEmpty())
            {
                items = JsonHelper.Deserialize<List<ReplaceItemModel>>(jsonReplaceString);
            }
        }

        private void BindData()
        {
            if (items.NotNullOrEmpty())
            {
                var list = new BindingList<ReplaceItemModel>(items);
                dgvReplace.DataSource = list;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CleanFields();
            btnUpdate.Enabled = false;
        }

        private void CleanFields()
        {
            txtKey.Text = "";
            var list = new BindingList<ValueModel>(new List<ValueModel>());
            dgvValues.DataSource = list;
            rdKey.Checked = false;
            rdValue.Checked = false;
        }

        private string Validation(bool isUpdate = false)
        {
            if (isUpdate && !txtIdSelected.Text.NotNullOrEmpty())
                return MessageConstans.NoDataSelected;
            if (!txtKey.Text.NotNullOrEmpty() && rdKey.Checked)
                return String.Format(MessageConstans.TheFieldEmpty, "key");
            if (!rdKey.Checked && !rdValue.Checked)
                return String.Format(MessageConstans.TheFieldEmpty, "type");

            var exist = items.FirstOrDefault(i => i.KeyName == txtKey.Text.Trim());
            if (exist != null)
            {
                if (!isUpdate || (isUpdate && exist.Id != new Guid(txtIdSelected.Text)))
                    return MessageConstans.ItemAlreadyExist;
            }

            /*
             * 1: valid
             * 2: missing new value
             * 3: type value missing old value
             */
            if (dgvValues.Rows.Count == 0)
                return String.Format(MessageConstans.TheFieldEmpty, "values");
            int validValues = 1;
            bool hasCheckedDefault = false;
            foreach (DataGridViewRow row in dgvValues.Rows)
            {
                if (row.Cells["clNewValue"].Value is null || !row.Cells["clNewValue"].Value.ToString().Trim().NotNullOrEmpty())
                {
                    validValues = 2;
                    break;
                }
                if (rdValue.Checked && (row.Cells["clOldValue"].Value is null || !row.Cells["clOldValue"].Value.ToString().Trim().NotNullOrEmpty()))
                {
                    validValues = 3;
                    break;
                }
                if (Convert.ToBoolean(row.Cells["clDefault"].Value) == true)
                    hasCheckedDefault = true;
            }
            if (validValues == 2)
                return String.Format(MessageConstans.TheFieldEmpty, "new value");
            if (validValues == 3)
                return String.Format(MessageConstans.TheFieldEmpty, "old value");
            if (!hasCheckedDefault)
                return String.Format(MessageConstans.MissingCheckedField, "default");

            return string.Empty;
        }

        private void dgvReplace_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.Value != null && dgvReplace.Columns["clType"].Index == e.ColumnIndex)
            {
                if (Convert.ToBoolean(e.Value) == true)
                    e.Value = "Key";
                else
                    e.Value = "Value";
            }
        }

        private void dgvReplace_SelectionChanged(object sender, EventArgs e)
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
                        txtIdSelected.Text = Id.ToString();
                        txtKey.Text = item.KeyName;

                        if (item.Type == true)
                        {
                            rdKey.Checked = true;
                            rdValue.Checked = false;
                        }
                        else
                        {
                            rdKey.Checked = false;
                            rdValue.Checked = true;
                        }
                        var list = new BindingList<ValueModel>(item.Values);
                        dgvValues.DataSource = list;
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
            var item = items.FirstOrDefault(m => m.Id == new Guid(txtIdSelected.Text));
            if (item != null)
            {

                item.KeyName = txtKey.Text.Trim();
                item.Type = rdKey.Checked ? true : false;
                List<ValueModel> values = new List<ValueModel>();
                foreach (DataGridViewRow row in dgvValues.Rows)
                {
                    if (row is null || (row.Cells["clOldValue"].Value is null && row.Cells["clNewValue"].Value is null))
                        continue;

                    values.Add(new ValueModel
                    {
                        OldValue = row.Cells["clOldValue"].Value?.ToString(),
                        NewValue = row.Cells["clNewValue"].Value?.ToString(),
                        Default = Convert.ToBoolean(row.Cells["clDefault"].Value)
                    });
                }
                var jsonData = JsonHelper.Serializer(items);
                var result = FileHelper.WriteFile(_replacePath, jsonData);
                if (!result)
                {
                    MessageBox.Show(MessageConstans.Failed);
                }
                else
                {
                    BindData();
                    MessageBox.Show(MessageConstans.Success);
                }
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
            List<ValueModel> values = new List<ValueModel>();
            foreach (DataGridViewRow row in dgvValues.Rows)
            {
                if (row is null || (row.Cells["clOldValue"].Value is null && row.Cells["clNewValue"].Value is null))
                    continue;

                values.Add(new ValueModel
                {
                    OldValue = row.Cells["clOldValue"].Value?.ToString(),
                    NewValue = row.Cells["clNewValue"].Value?.ToString(),
                    Default = Convert.ToBoolean(row.Cells["clDefault"].Value)
                });
            }
            ReplaceItemModel newItem = new ReplaceItemModel
            {
                Id = Guid.NewGuid(),
                KeyName = txtKey.Text.Trim(),
                Type = rdKey.Checked ? true : false,
                Values = values
            };
            items.Add(newItem);
            var jsonData = JsonHelper.Serializer(items);
            var result = FileHelper.WriteFile(_replacePath, jsonData);
            if (result)
            {
                BindData();
                MessageBox.Show(MessageConstans.Success);
            }
            else
            {
                MessageBox.Show(MessageConstans.Failed);
            }
        }

        private void dgvValues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            for (int i = 0; i < dgvValues.Rows.Count; i++)
            {
                if (row_index != i)
                {
                    dgvValues.Rows[i].Cells["clDefault"].Value = false;
                }
            }

            if (e.ColumnIndex == dgvValues.Columns["clDefault"].Index)
            {
                dgvValues.EndEdit();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rdProject.Checked)
            {
                FindFiles(Global.Configuration.ProjectFolder);
            }   
            if (rdPublish.Checked)
            {
                FindFiles(Global.Configuration.PublishFolder);
            }    
        }

        private void FindFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            //FileInfo[] appsettingFiles = di.GetFiles("appsettings.json", SearchOption.AllDirectories);
            //foreach (FileInfo file in appsettingFiles)
            //{
            //    if (file.DirectoryName.Contains("\\bin\\") || file.DirectoryName.Contains("\\obj\\"))
            //        continue;
            //    HandleAppsettingFile(file);
            //}
            FileInfo[] appsettingLocalFiles = di.GetFiles("appsettings.Local.json", SearchOption.AllDirectories);
            foreach (FileInfo file in appsettingLocalFiles)
            {
                if (file.DirectoryName.Contains("\\bin\\") || file.DirectoryName.Contains("\\obj\\"))
                    continue;
                HandleAppsettingFile(file);
            }
        }

        private void HandleAppsettingFile(FileInfo file)
        {
            string text = System.IO.File.ReadAllText(file.FullName);
            foreach (var item in items)
            {
                var value = item.Values.FirstOrDefault(x => x.Default);
                if (!item.Type)//replace by value
                {
                    text = Regex.Replace(text, "\""+ value.OldValue + "\"", "\"" + value.NewValue + "\"", RegexOptions.Singleline);
                }
                else//replace by key
                {
                } 
            }    
        }
    }
}

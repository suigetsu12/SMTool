using SM.Models;
using SM.Models.Storage;
using SM.Shared.Constants;
using SM.Shared.Enums;
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

namespace SM.Forms.Forms.Publishes
{
    public partial class frmDatabase : Form
    {
        private string pathData;
        private string databaseFolderPath;
        private List<DatabaseItemModel> items;
        private string selectedItem;
        public frmDatabase()
        {
            InitializeComponent();
            databaseFolderPath = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Database);
            pathData = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Database);
            LoadData();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (selectedItem.NotNullOrEmpty() && databaseFolderPath.NotNullOrEmpty())
            {
                try
                {
                    var filePath = databaseFolderPath + @"\" + selectedItem;
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show(MessageConstans.FileDoesNotExist);
                    }
                    else
                    {
                        CommandLineHelper.Run(databaseFolderPath, filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadData()
        {
            var jsonData = FileHelper.ReadFile(pathData);
            if (jsonData.NotNullOrEmpty())
            {
                items = JsonHelper.Deserialize<List<DatabaseItemModel>>(jsonData);
            }
        }

        private void BindData(DatabaseActionType type)
        {
            if (!items.IsNullOrEmpty())
            {
                var _data = items.FindAll(i => i.ActionType == type);
                if (!_data.IsNullOrEmpty())
                {
                    pnItems.Controls.Clear();
                    int yPoint = 15;
                    foreach (var item in _data)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Text = item.Name;
                        rb.Width = 600;
                        rb.CheckedChanged += new EventHandler(this.CheckedChangeItem);
                        pnItems.Controls.Add(rb);
                        rb.Location = new Point(15, yPoint);
                        yPoint += 30;
                    }
                    selectedItem = string.Empty;
                    btnRun.Enabled = false;
                }
            }
        }

        private void CheckedChangeItem(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked)
            {
                selectedItem = items.Find(i => i.Name == r.Text).FileName;
                btnRun.Enabled = true;
            }
            else
            {
                selectedItem = string.Empty;
                btnRun.Enabled = false;
            }

        }

        private void rdbDeploy_CheckedChanged(object sender, EventArgs e)
        {
            BindData(DatabaseActionType.Deploy);
        }

        private void rdbMigrate_CheckedChanged(object sender, EventArgs e)
        {
            BindData(DatabaseActionType.Migrate);
        }

        private void rdbBackup_CheckedChanged(object sender, EventArgs e)
        {
            BindData(DatabaseActionType.Backup);
        }

        private void rdbRestore_CheckedChanged(object sender, EventArgs e)
        {
            BindData(DatabaseActionType.Restore);
        }

        private void rdbDrop_CheckedChanged(object sender, EventArgs e)
        {
            BindData(DatabaseActionType.Drop);
        }
    }
}

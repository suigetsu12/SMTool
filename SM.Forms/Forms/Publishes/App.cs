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
    public partial class frmApp : Form
    {
        private string publishFolderPath;
        private string pathData;
        private List<PublishItemModel> items;
        private string selectedItem;
        public frmApp()
        {
            InitializeComponent();
            publishFolderPath = Path.Combine(Global.RootAppFolderPath, FolderConstants.Bat.Publish);
            pathData = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Publish);
            LoadData();
        }

        private void LoadData()
        {
            var jsonData = FileHelper.ReadFile(pathData);
            if (jsonData.NotNullOrEmpty())
            {
                items = JsonHelper.Deserialize<List<PublishItemModel>>(jsonData);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (selectedItem.NotNullOrEmpty() && publishFolderPath.NotNullOrEmpty())
            {
                try
                {
                    var filePath = publishFolderPath + @"\" + selectedItem;
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show(MessageConstans.FileDoesNotExist);
                    }
                    else
                    {
                        CommandLineHelper.Run(publishFolderPath, filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BindData(PublishType type)
        {
            if (!items.IsNullOrEmpty())
            {
                var _data = items.FindAll(i => i.PublishType == type);
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
                    btnPublish.Enabled = false;
                }
            }
        }

        private void CheckedChangeItem(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked)
            {
                selectedItem = items.Find(i => i.Name == r.Text).FileName;
                btnPublish.Enabled = true;
            }
            else
            {
                selectedItem = string.Empty;
                btnPublish.Enabled = false;
            }
        }

        private void rdbFeature_CheckedChanged(object sender, EventArgs e)
        {
            BindData(PublishType.Feature);
        }

        private void rdbFunction_CheckedChanged(object sender, EventArgs e)
        {
            BindData(PublishType.Function);
        }
    }
}

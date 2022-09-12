using SM.Forms.Forms.Publishes;
using SM.Forms.Forms.Settings;
using SM.Models;
using SM.Models.Controls;
using SM.Models.Storage;
using SM.Shared.Constants;
using SM.Shared.Enums;
using SM.Shared.Extensions;
using SM.Shared.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.Forms.Forms
{
    public partial class frmMain : Form
    {
        private List<StartItemModel> memoryStartItems = new List<StartItemModel>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadFeatureData();
            BindGridData();
            RenderRun();
            if (Global.StartItem.NotNullOrEmpty())
            {
                memoryStartItems = Global.StartItem.Select(x => new StartItemModel()
                {
                    Id = x.Id,
                    Features = x.Features,
                    FileName = x.FileName,
                    IsChecked = x.IsChecked,
                    Message = x.Message,
                    Name = x.Name,
                    ProcessId = x.ProcessId
                }).ToList();
            }    
        }

        private void LoadFeatureData()
        {
            List<DropdownItemModel> items = new List<DropdownItemModel>();
            DropdownItemModel firstItem = new DropdownItemModel
            {
                Text = "Selected Items",
                Value = -1
            };
            cbRunFeatures.Items.Add(firstItem);
            foreach (FeatureType ft in Enum.GetValues(typeof(FeatureType)))
            {
                DropdownItemModel item = new DropdownItemModel
                {
                    Text = ft.StringValueOfEnum(),
                    Value = (int)ft
                };
                cbRunFeatures.Items.Add(item);
            }
            cbRunFeatures.SelectedIndex = 0;
        }

        private void BindGridData()
        {
            if (Global.StartItem.NotNullOrEmpty())
            {
                var list = new BindingList<StartItemModel>(Global.StartItem);
                dgvStart.DataSource = list;
            }
        }

        private void Refresh()
        {
            dgvStart.Invoke(new MethodInvoker(() => dgvStart.Refresh()));
            RenderRun();
        }

        private void RenderRun()
        {
            btnRun.Invoke(new MethodInvoker(() =>
            {
                if (Global.StartItem.Any(x => x.IsChecked))
                    btnRun.Enabled = true;
                else
                    btnRun.Enabled = false;
            }));
        }

        private void mtConfiguration_Click(object sender, EventArgs e)
        {
            ShowForm(new frmConfiguration());
        }

        private void mtSQLConfiguration_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSQL());
        }

        private void mtServers_Click(object sender, EventArgs e)
        {
            ShowForm(new frmServer());
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            Parallel.ForEach(Global.StartItem, item =>
            {
                item.IsChecked = true;
            });
            Refresh();
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            Parallel.ForEach(Global.StartItem, item =>
            {
                item.IsChecked = false;
            });
            Refresh();
        }

        private void cbRunFeatures_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = ((DropdownItemModel)cbRunFeatures.SelectedItem).Value;
            if (selectedItem == -1)
            {
                if (memoryStartItems.NotNullOrEmpty())
                {
                    var checkedItemIds = memoryStartItems.Where(x => x.IsChecked).Select(x => x.Id);
                    Parallel.ForEach(Global.StartItem, item =>
                    {
                        if (checkedItemIds.Contains(item.Id))
                            item.IsChecked = true;
                        else
                            item.IsChecked = false;
                    });
                }    
            }
            else
            {
                var featureItem = (FeatureType)selectedItem;
                Parallel.ForEach(Global.StartItem, item =>
                {
                    if (item.Features.Contains(featureItem))
                        item.IsChecked = true;
                    else
                        item.IsChecked = false;
                });
            }
            Refresh();
        }

        private void mtPublishApp_Click(object sender, EventArgs e)
        {
            ShowForm(new frmApp());
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void mtPublishDatabase_Click(object sender, EventArgs e)
        {
            ShowForm(new frmDatabase());
        }
    }
}

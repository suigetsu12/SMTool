using SM.Forms.Forms.Publishes;
using SM.Forms.Forms.Settings;
using SM.Forms.Forms.Settings.Data;
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
        private List<BaseItemModel> features = new List<BaseItemModel>();
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
                    ProcessId = x.ProcessId,
                    Order = x.Order
                }).ToList();
            }    
        }

        private void LoadFeatureData()
        {
            string _featurePath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Feature);
            string jsonFeatureString = FileHelper.ReadFile(_featurePath);
            if (jsonFeatureString.NotNullOrEmpty())
            {
                features = (JsonHelper.Deserialize<List<BaseItemModel>>(jsonFeatureString)).OrderBy(o => o.Order).ToList();
            }
            List<FeatureDropdownItemModel> items = new List<FeatureDropdownItemModel>();
            FeatureDropdownItemModel firstItem = new FeatureDropdownItemModel
            {
                Text = "Selected Items",
                Value = Guid.Empty
            };
            cbRunFeatures.Items.Add(firstItem);

            foreach (var  ft in features)
            {
                FeatureDropdownItemModel item = new FeatureDropdownItemModel
                {
                    Text = ft.Name,
                    Value = ft.Id
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
            var selectedItem = ((FeatureDropdownItemModel)cbRunFeatures.SelectedItem).Value;
            if (selectedItem == Guid.Empty)
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
                var featureItem = (Guid)selectedItem;
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

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void mtFeatures_Click(object sender, EventArgs e)
        {

        }

        private void mtPublish_Click(object sender, EventArgs e)
        {
            ShowForm(new frmDataPublish());
        }

        private void dgvStart_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStart.Rows)
            {
                var value = row.Cells["clMessage"].Value?.ToString();
                if (value.NotNullOrEmpty())
                {
                    if (value == MessageConstans.Running)
                        row.Cells["clMessage"].Style.ForeColor = Color.Blue;
                    else
                        row.Cells["clMessage"].Style.ForeColor = Color.Red;
                }
                else
                    row.Cells["clMessage"].Style.ForeColor = Color.Black;
            }
        }

        private void mtStart_Click(object sender, EventArgs e)
        {
            ShowForm(new frmDataStart());
        }

        private void mtFeature_Click(object sender, EventArgs e)
        {
            ShowForm(new frmFeature());
        }
    }
}

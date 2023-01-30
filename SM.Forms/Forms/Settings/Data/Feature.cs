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
    public partial class frmFeature : Form
    {
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        private List<BaseItemModel> features = new List<BaseItemModel>();
        private string _featurePath = string.Empty;
        public frmFeature()
        {
            _featurePath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Feature);
            LoadFeature();
            InitializeComponent();
            BindData();
        }

        private void LoadFeature()
        {
            string jsonFeatureString = FileHelper.ReadFile(_featurePath);
            if (jsonFeatureString.NotNullOrEmpty())
            {
                features = JsonHelper.Deserialize<List<BaseItemModel>>(jsonFeatureString);
            }
        }

        private void BindData()
        {
            if (features.NotNullOrEmpty())
            {
                var list = new BindingList<BaseItemModel>(features.OrderBy(o => o.Order).ToList());
                dgvFeature.DataSource = list;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            features = new List<BaseItemModel>();
            int order = 0;
            foreach (DataGridViewRow row in dgvFeature.Rows)
            {
                if (row != null)
                {
                    if (row.Cells["clName"].Value is null || !row.Cells["clName"].Value.ToString().Trim().NotNullOrEmpty())
                        continue;

                    if (row.Cells["clId"].Value is null || row.Cells["clId"].Value.ToString() == Guid.Empty.ToString())
                    {
                        features.Add(new BaseItemModel
                        {
                            Id = Guid.NewGuid(),
                            Name = row.Cells["clName"].Value.ToString(),
                            Order = order
                        });
                    }
                    else
                    {
                        features.Add(new BaseItemModel
                        {
                            Id = new Guid(row.Cells["clId"].Value.ToString()),
                            Name = row.Cells["clName"].Value.ToString(),
                            Order = order
                        });
                    }
                    order++;
                }
            }
            var jsonData = JsonHelper.Serializer(features);
            var result = FileHelper.WriteFile(_featurePath, jsonData);
            if (result)
            {
                MessageBox.Show(MessageConstans.Success);
            }
            else
            {
                MessageBox.Show(MessageConstans.Failed);
            }
            BindData();
        }

        private void dgvFeature_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvFeature.DoDragDrop(
                          dgvFeature.Rows[rowIndexFromMouseDown],
                          DragDropEffects.Move);
                }
            }
        }

        private void dgvFeature_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgvFeature.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvFeature_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvFeature_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvFeature.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = dgvFeature.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                if (rowIndexOfItemUnderMouseToDrop < features.Count && rowIndexOfItemUnderMouseToDrop > 0)
                {
                    DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                    var itemToMove = (BaseItemModel)rowToMove.DataBoundItem;
                    features.RemoveAt(rowIndexFromMouseDown);
                    features.Insert(rowIndexOfItemUnderMouseToDrop, itemToMove);
                    var list = new BindingList<BaseItemModel>(features);
                    dgvFeature.DataSource = list;
                }
            }
        }
    }
}

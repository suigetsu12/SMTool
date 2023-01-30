namespace SM.Forms.Forms.Settings.Data
{
    partial class frmFeature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFeature = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeature
            // 
            this.dgvFeature.AllowDrop = true;
            this.dgvFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName,
            this.clOrder});
            this.dgvFeature.Location = new System.Drawing.Point(12, 12);
            this.dgvFeature.MultiSelect = false;
            this.dgvFeature.Name = "dgvFeature";
            this.dgvFeature.RowHeadersWidth = 51;
            this.dgvFeature.RowTemplate.Height = 29;
            this.dgvFeature.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeature.Size = new System.Drawing.Size(539, 433);
            this.dgvFeature.TabIndex = 0;
            this.dgvFeature.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFeature_DragDrop);
            this.dgvFeature.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvFeature_DragOver);
            this.dgvFeature.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFeature_MouseDown);
            this.dgvFeature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvFeature_MouseMove);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 456);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "id";
            this.clId.HeaderText = "Id";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 75;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "name";
            this.clName.HeaderText = "Name";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.Width = 300;
            // 
            // clOrder
            // 
            this.clOrder.DataPropertyName = "order";
            this.clOrder.HeaderText = "Order";
            this.clOrder.MinimumWidth = 6;
            this.clOrder.Name = "clOrder";
            this.clOrder.ReadOnly = true;
            this.clOrder.Visible = false;
            this.clOrder.Width = 125;
            // 
            // frmFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 497);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvFeature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFeature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feature";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvFeature;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clName;
        private DataGridViewTextBoxColumn clOrder;
    }
}
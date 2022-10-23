namespace SM.Forms.Forms.Settings.Data
{
    partial class frmDataStart
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
            this.dgvStart = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFeatures = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnFeature = new System.Windows.Forms.FlowLayoutPanel();
            this.lbIdSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStart
            // 
            this.dgvStart.AllowUserToAddRows = false;
            this.dgvStart.AllowUserToDeleteRows = false;
            this.dgvStart.AllowUserToResizeRows = false;
            this.dgvStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName,
            this.clFileName,
            this.clIsChecked,
            this.clOrder,
            this.clProcessId,
            this.clFeatures,
            this.clMessage});
            this.dgvStart.Location = new System.Drawing.Point(12, 12);
            this.dgvStart.MultiSelect = false;
            this.dgvStart.Name = "dgvStart";
            this.dgvStart.ReadOnly = true;
            this.dgvStart.RowHeadersVisible = false;
            this.dgvStart.RowHeadersWidth = 51;
            this.dgvStart.RowTemplate.Height = 29;
            this.dgvStart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStart.Size = new System.Drawing.Size(324, 553);
            this.dgvStart.TabIndex = 0;
            this.dgvStart.SelectionChanged += new System.EventHandler(this.dgvStart_SelectionChanged);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Id";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            this.clId.Width = 125;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Name";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 125;
            // 
            // clFileName
            // 
            this.clFileName.DataPropertyName = "FileName";
            this.clFileName.HeaderText = "File Name";
            this.clFileName.MinimumWidth = 6;
            this.clFileName.Name = "clFileName";
            this.clFileName.ReadOnly = true;
            this.clFileName.Width = 125;
            // 
            // clIsChecked
            // 
            this.clIsChecked.DataPropertyName = "IsChecked";
            this.clIsChecked.HeaderText = "Is Checked";
            this.clIsChecked.MinimumWidth = 6;
            this.clIsChecked.Name = "clIsChecked";
            this.clIsChecked.ReadOnly = true;
            this.clIsChecked.Visible = false;
            this.clIsChecked.Width = 125;
            // 
            // clOrder
            // 
            this.clOrder.DataPropertyName = "Order";
            this.clOrder.HeaderText = "Order";
            this.clOrder.MinimumWidth = 6;
            this.clOrder.Name = "clOrder";
            this.clOrder.ReadOnly = true;
            this.clOrder.Visible = false;
            this.clOrder.Width = 125;
            // 
            // clProcessId
            // 
            this.clProcessId.DataPropertyName = "ProcessId";
            this.clProcessId.HeaderText = "Process";
            this.clProcessId.MinimumWidth = 6;
            this.clProcessId.Name = "clProcessId";
            this.clProcessId.ReadOnly = true;
            this.clProcessId.Visible = false;
            this.clProcessId.Width = 125;
            // 
            // clFeatures
            // 
            this.clFeatures.DataPropertyName = "Features";
            this.clFeatures.HeaderText = "Features";
            this.clFeatures.MinimumWidth = 6;
            this.clFeatures.Name = "clFeatures";
            this.clFeatures.ReadOnly = true;
            this.clFeatures.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clFeatures.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clFeatures.Visible = false;
            this.clFeatures.Width = 125;
            // 
            // clMessage
            // 
            this.clMessage.DataPropertyName = "Message";
            this.clMessage.HeaderText = "Message";
            this.clMessage.MinimumWidth = 6;
            this.clMessage.Name = "clMessage";
            this.clMessage.ReadOnly = true;
            this.clMessage.Visible = false;
            this.clMessage.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(349, 234);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(485, 301);
            this.txtContent.TabIndex = 24;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(671, 47);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(163, 27);
            this.txtFileName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "File Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(420, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 27);
            this.txtName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(342, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(170, 29);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "Clean All Fields";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(640, 541);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(740, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Feature";
            // 
            // pnFeature
            // 
            this.pnFeature.AutoScroll = true;
            this.pnFeature.Location = new System.Drawing.Point(420, 80);
            this.pnFeature.Name = "pnFeature";
            this.pnFeature.Size = new System.Drawing.Size(411, 133);
            this.pnFeature.TabIndex = 27;
            // 
            // lbIdSelected
            // 
            this.lbIdSelected.AutoSize = true;
            this.lbIdSelected.Location = new System.Drawing.Point(359, 545);
            this.lbIdSelected.Name = "lbIdSelected";
            this.lbIdSelected.Size = new System.Drawing.Size(0, 20);
            this.lbIdSelected.TabIndex = 28;
            this.lbIdSelected.Visible = false;
            // 
            // frmDataStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 577);
            this.Controls.Add(this.lbIdSelected);
            this.Controls.Add(this.pnFeature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDataStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvStart;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clName;
        private DataGridViewTextBoxColumn clFileName;
        private DataGridViewTextBoxColumn clIsChecked;
        private DataGridViewTextBoxColumn clOrder;
        private DataGridViewTextBoxColumn clProcessId;
        private DataGridViewComboBoxColumn clFeatures;
        private DataGridViewTextBoxColumn clMessage;
        private Label label4;
        private TextBox txtContent;
        private TextBox txtFileName;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label5;
        private FlowLayoutPanel pnFeature;
        private Label lbIdSelected;
    }
}
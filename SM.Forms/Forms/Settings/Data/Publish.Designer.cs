namespace SM.Forms.Forms.Settings.Data
{
    partial class frmDataPublish
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
            this.dgvPublish = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPublishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdFeature = new System.Windows.Forms.RadioButton();
            this.rdFunction = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIdSelected = new System.Windows.Forms.Label();
            this.txtProjectFolder = new System.Windows.Forms.TextBox();
            this.lbProjectFolder = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.lbOutputFolder = new System.Windows.Forms.Label();
            this.txtOutputParam = new System.Windows.Forms.TextBox();
            this.lbOutputParam = new System.Windows.Forms.Label();
            this.txtProjectParam = new System.Windows.Forms.TextBox();
            this.lbProjectParam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublish)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPublish
            // 
            this.dgvPublish.AllowUserToAddRows = false;
            this.dgvPublish.AllowUserToDeleteRows = false;
            this.dgvPublish.AllowUserToResizeColumns = false;
            this.dgvPublish.AllowUserToResizeRows = false;
            this.dgvPublish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName,
            this.clFileName,
            this.clDescription,
            this.clPublishType,
            this.clOrder});
            this.dgvPublish.Location = new System.Drawing.Point(12, 12);
            this.dgvPublish.MultiSelect = false;
            this.dgvPublish.Name = "dgvPublish";
            this.dgvPublish.ReadOnly = true;
            this.dgvPublish.RowHeadersVisible = false;
            this.dgvPublish.RowHeadersWidth = 51;
            this.dgvPublish.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPublish.RowTemplate.Height = 29;
            this.dgvPublish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublish.Size = new System.Drawing.Size(324, 553);
            this.dgvPublish.TabIndex = 0;
            this.dgvPublish.SelectionChanged += new System.EventHandler(this.dgvPublish_SelectionChanged);
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
            // clDescription
            // 
            this.clDescription.DataPropertyName = "Description";
            this.clDescription.HeaderText = "Description";
            this.clDescription.MinimumWidth = 6;
            this.clDescription.Name = "clDescription";
            this.clDescription.ReadOnly = true;
            this.clDescription.Width = 125;
            // 
            // clPublishType
            // 
            this.clPublishType.DataPropertyName = "PublishType";
            this.clPublishType.HeaderText = "Publish Type";
            this.clPublishType.MinimumWidth = 6;
            this.clPublishType.Name = "clPublishType";
            this.clPublishType.ReadOnly = true;
            this.clPublishType.Visible = false;
            this.clPublishType.Width = 125;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(740, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(640, 541);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(342, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(170, 29);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Clean All Fields";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(440, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(440, 80);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(163, 27);
            this.txtFileName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(440, 113);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(163, 93);
            this.txtDescription.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // rdFeature
            // 
            this.rdFeature.AutoSize = true;
            this.rdFeature.Location = new System.Drawing.Point(3, 3);
            this.rdFeature.Name = "rdFeature";
            this.rdFeature.Size = new System.Drawing.Size(79, 24);
            this.rdFeature.TabIndex = 10;
            this.rdFeature.TabStop = true;
            this.rdFeature.Text = "Feature";
            this.rdFeature.UseVisualStyleBackColor = true;
            this.rdFeature.CheckedChanged += new System.EventHandler(this.rdFeature_CheckedChanged);
            // 
            // rdFunction
            // 
            this.rdFunction.AutoSize = true;
            this.rdFunction.Location = new System.Drawing.Point(103, 3);
            this.rdFunction.Name = "rdFunction";
            this.rdFunction.Size = new System.Drawing.Size(86, 24);
            this.rdFunction.TabIndex = 11;
            this.rdFunction.TabStop = true;
            this.rdFunction.Text = "Function";
            this.rdFunction.UseVisualStyleBackColor = true;
            this.rdFunction.CheckedChanged += new System.EventHandler(this.rdFunction_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdFeature);
            this.panel1.Controls.Add(this.rdFunction);
            this.panel1.Location = new System.Drawing.Point(613, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 31);
            this.panel1.TabIndex = 12;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(349, 234);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(485, 301);
            this.txtContent.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Content";
            // 
            // lbIdSelected
            // 
            this.lbIdSelected.AutoSize = true;
            this.lbIdSelected.Location = new System.Drawing.Point(19, 505);
            this.lbIdSelected.Name = "lbIdSelected";
            this.lbIdSelected.Size = new System.Drawing.Size(0, 20);
            this.lbIdSelected.TabIndex = 15;
            this.lbIdSelected.Visible = false;
            // 
            // txtProjectFolder
            // 
            this.txtProjectFolder.Location = new System.Drawing.Point(716, 80);
            this.txtProjectFolder.Name = "txtProjectFolder";
            this.txtProjectFolder.Size = new System.Drawing.Size(118, 27);
            this.txtProjectFolder.TabIndex = 17;
            this.txtProjectFolder.Visible = false;
            // 
            // lbProjectFolder
            // 
            this.lbProjectFolder.AutoSize = true;
            this.lbProjectFolder.Location = new System.Drawing.Point(609, 83);
            this.lbProjectFolder.Name = "lbProjectFolder";
            this.lbProjectFolder.Size = new System.Drawing.Size(101, 20);
            this.lbProjectFolder.TabIndex = 16;
            this.lbProjectFolder.Text = "Project Folder";
            this.lbProjectFolder.Visible = false;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(716, 146);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(118, 27);
            this.txtOutputFolder.TabIndex = 19;
            this.txtOutputFolder.Visible = false;
            // 
            // lbOutputFolder
            // 
            this.lbOutputFolder.AutoSize = true;
            this.lbOutputFolder.Location = new System.Drawing.Point(609, 149);
            this.lbOutputFolder.Name = "lbOutputFolder";
            this.lbOutputFolder.Size = new System.Drawing.Size(101, 20);
            this.lbOutputFolder.TabIndex = 18;
            this.lbOutputFolder.Text = "Output Folder";
            this.lbOutputFolder.Visible = false;
            // 
            // txtOutputParam
            // 
            this.txtOutputParam.Location = new System.Drawing.Point(716, 179);
            this.txtOutputParam.Name = "txtOutputParam";
            this.txtOutputParam.Size = new System.Drawing.Size(118, 27);
            this.txtOutputParam.TabIndex = 23;
            this.txtOutputParam.Visible = false;
            // 
            // lbOutputParam
            // 
            this.lbOutputParam.AutoSize = true;
            this.lbOutputParam.Location = new System.Drawing.Point(609, 182);
            this.lbOutputParam.Name = "lbOutputParam";
            this.lbOutputParam.Size = new System.Drawing.Size(100, 20);
            this.lbOutputParam.TabIndex = 22;
            this.lbOutputParam.Text = "Output Param";
            this.lbOutputParam.Visible = false;
            // 
            // txtProjectParam
            // 
            this.txtProjectParam.Location = new System.Drawing.Point(716, 113);
            this.txtProjectParam.Name = "txtProjectParam";
            this.txtProjectParam.Size = new System.Drawing.Size(118, 27);
            this.txtProjectParam.TabIndex = 21;
            this.txtProjectParam.Visible = false;
            // 
            // lbProjectParam
            // 
            this.lbProjectParam.AutoSize = true;
            this.lbProjectParam.Location = new System.Drawing.Point(630, 116);
            this.lbProjectParam.Name = "lbProjectParam";
            this.lbProjectParam.Size = new System.Drawing.Size(80, 20);
            this.lbProjectParam.TabIndex = 20;
            this.lbProjectParam.Text = "Proj Param";
            this.lbProjectParam.Visible = false;
            // 
            // frmDataPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 577);
            this.Controls.Add(this.txtOutputParam);
            this.Controls.Add(this.lbOutputParam);
            this.Controls.Add(this.txtProjectParam);
            this.Controls.Add(this.lbProjectParam);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.lbOutputFolder);
            this.Controls.Add(this.txtProjectFolder);
            this.Controls.Add(this.lbProjectFolder);
            this.Controls.Add(this.lbIdSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPublish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDataPublish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publish";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublish)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPublish;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnNew;
        private Label label1;
        private TextBox txtName;
        private TextBox txtFileName;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private RadioButton rdFeature;
        private RadioButton rdFunction;
        private Panel panel1;
        private TextBox txtContent;
        private Label label4;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clName;
        private DataGridViewTextBoxColumn clFileName;
        private DataGridViewTextBoxColumn clDescription;
        private DataGridViewTextBoxColumn clPublishType;
        private DataGridViewTextBoxColumn clOrder;
        private Label lbIdSelected;
        private TextBox txtProjectFolder;
        private Label lbProjectFolder;
        private TextBox txtOutputFolder;
        private Label lbOutputFolder;
        private TextBox txtOutputParam;
        private Label lbOutputParam;
        private TextBox txtProjectParam;
        private Label lbProjectParam;
    }
}
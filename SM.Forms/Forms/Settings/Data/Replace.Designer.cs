namespace SM.Forms.Forms.Settings.Data
{
    partial class frmReplace
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvReplace = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdValue = new System.Windows.Forms.RadioButton();
            this.rdKey = new System.Windows.Forms.RadioButton();
            this.dgvValues = new System.Windows.Forms.DataGridView();
            this.clOldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdProject = new System.Windows.Forms.RadioButton();
            this.rdPublish = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplace)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.Red;
            this.btnRun.Location = new System.Drawing.Point(710, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(78, 82);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(327, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(207, 29);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Clean All Fields";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(327, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(429, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvReplace
            // 
            this.dgvReplace.AllowUserToAddRows = false;
            this.dgvReplace.AllowUserToDeleteRows = false;
            this.dgvReplace.AllowUserToResizeRows = false;
            this.dgvReplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clType,
            this.clKeyName,
            this.clValue});
            this.dgvReplace.Location = new System.Drawing.Point(12, 12);
            this.dgvReplace.Name = "dgvReplace";
            this.dgvReplace.ReadOnly = true;
            this.dgvReplace.RowHeadersWidth = 51;
            this.dgvReplace.RowTemplate.Height = 29;
            this.dgvReplace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReplace.Size = new System.Drawing.Size(309, 564);
            this.dgvReplace.TabIndex = 7;
            this.dgvReplace.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReplace_CellFormatting);
            this.dgvReplace.SelectionChanged += new System.EventHandler(this.dgvReplace_SelectionChanged);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "id";
            this.clId.Frozen = true;
            this.clId.HeaderText = "Id";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            this.clId.Width = 125;
            // 
            // clType
            // 
            this.clType.DataPropertyName = "type";
            this.clType.Frozen = true;
            this.clType.HeaderText = "Type";
            this.clType.MinimumWidth = 6;
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            this.clType.Width = 125;
            // 
            // clKeyName
            // 
            this.clKeyName.DataPropertyName = "keyName";
            this.clKeyName.Frozen = true;
            this.clKeyName.HeaderText = "Key";
            this.clKeyName.MinimumWidth = 6;
            this.clKeyName.Name = "clKeyName";
            this.clKeyName.ReadOnly = true;
            this.clKeyName.Width = 200;
            // 
            // clValue
            // 
            this.clValue.DataPropertyName = "values";
            this.clValue.Frozen = true;
            this.clValue.HeaderText = "Values";
            this.clValue.MinimumWidth = 6;
            this.clValue.Name = "clValue";
            this.clValue.ReadOnly = true;
            this.clValue.Visible = false;
            this.clValue.Width = 125;
            // 
            // txtIdSelected
            // 
            this.txtIdSelected.Location = new System.Drawing.Point(663, 549);
            this.txtIdSelected.Name = "txtIdSelected";
            this.txtIdSelected.ReadOnly = true;
            this.txtIdSelected.Size = new System.Drawing.Size(125, 27);
            this.txtIdSelected.TabIndex = 8;
            this.txtIdSelected.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(366, 100);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(422, 27);
            this.txtKey.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdValue);
            this.groupBox1.Controls.Add(this.rdKey);
            this.groupBox1.Location = new System.Drawing.Point(327, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 51);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rdValue
            // 
            this.rdValue.AutoSize = true;
            this.rdValue.Location = new System.Drawing.Point(229, 18);
            this.rdValue.Name = "rdValue";
            this.rdValue.Size = new System.Drawing.Size(66, 24);
            this.rdValue.TabIndex = 1;
            this.rdValue.TabStop = true;
            this.rdValue.Text = "Value";
            this.rdValue.UseVisualStyleBackColor = true;
            // 
            // rdKey
            // 
            this.rdKey.AutoSize = true;
            this.rdKey.Location = new System.Drawing.Point(100, 18);
            this.rdKey.Name = "rdKey";
            this.rdKey.Size = new System.Drawing.Size(54, 24);
            this.rdKey.TabIndex = 0;
            this.rdKey.TabStop = true;
            this.rdKey.Text = "Key";
            this.rdKey.UseVisualStyleBackColor = true;
            // 
            // dgvValues
            // 
            this.dgvValues.AllowUserToResizeRows = false;
            this.dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOldValue,
            this.clNewValue,
            this.clDefault});
            this.dgvValues.Location = new System.Drawing.Point(327, 190);
            this.dgvValues.Name = "dgvValues";
            this.dgvValues.RowHeadersWidth = 51;
            this.dgvValues.RowTemplate.Height = 29;
            this.dgvValues.Size = new System.Drawing.Size(461, 386);
            this.dgvValues.TabIndex = 12;
            this.dgvValues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvValues_CellContentClick);
            // 
            // clOldValue
            // 
            this.clOldValue.DataPropertyName = "oldValue";
            this.clOldValue.HeaderText = "Old Value";
            this.clOldValue.MinimumWidth = 6;
            this.clOldValue.Name = "clOldValue";
            this.clOldValue.Width = 175;
            // 
            // clNewValue
            // 
            this.clNewValue.DataPropertyName = "newValue";
            this.clNewValue.HeaderText = "New Value";
            this.clNewValue.MinimumWidth = 6;
            this.clNewValue.Name = "clNewValue";
            this.clNewValue.Width = 175;
            // 
            // clDefault
            // 
            this.clDefault.DataPropertyName = "default";
            this.clDefault.HeaderText = "Default";
            this.clDefault.MinimumWidth = 6;
            this.clDefault.Name = "clDefault";
            this.clDefault.Width = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdPublish);
            this.groupBox2.Controls.Add(this.rdProject);
            this.groupBox2.Location = new System.Drawing.Point(556, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 82);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area";
            // 
            // rdProject
            // 
            this.rdProject.AutoSize = true;
            this.rdProject.Checked = true;
            this.rdProject.Location = new System.Drawing.Point(31, 26);
            this.rdProject.Name = "rdProject";
            this.rdProject.Size = new System.Drawing.Size(76, 24);
            this.rdProject.TabIndex = 0;
            this.rdProject.TabStop = true;
            this.rdProject.Text = "Project";
            this.rdProject.UseVisualStyleBackColor = true;
            // 
            // rdPublish
            // 
            this.rdPublish.AutoSize = true;
            this.rdPublish.Location = new System.Drawing.Point(31, 54);
            this.rdPublish.Name = "rdPublish";
            this.rdPublish.Size = new System.Drawing.Size(77, 24);
            this.rdPublish.TabIndex = 1;
            this.rdPublish.Text = "Publish";
            this.rdPublish.UseVisualStyleBackColor = true;
            // 
            // frmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvValues);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdSelected);
            this.Controls.Add(this.dgvReplace);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRun;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvReplace;
        private TextBox txtIdSelected;
        private Label label1;
        private TextBox txtKey;
        private GroupBox groupBox1;
        private RadioButton rdValue;
        private RadioButton rdKey;
        private DataGridView dgvValues;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clType;
        private DataGridViewTextBoxColumn clKeyName;
        private DataGridViewTextBoxColumn clValue;
        private DataGridViewTextBoxColumn clOldValue;
        private DataGridViewTextBoxColumn clNewValue;
        private DataGridViewCheckBoxColumn clDefault;
        private GroupBox groupBox2;
        private RadioButton rdPublish;
        private RadioButton rdProject;
    }
}
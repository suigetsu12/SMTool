﻿namespace SM.Forms.Forms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.mtSQLConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.mtServers = new System.Windows.Forms.ToolStripMenuItem();
            this.storagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtStoragePublish = new System.Windows.Forms.ToolStripMenuItem();
            this.mtStorageStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mtStorageDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mtStorageReplaceAppSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.publishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mtPublishApp = new System.Windows.Forms.ToolStripMenuItem();
            this.mtPublishDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cbRunFeatures = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStart = new System.Windows.Forms.DataGridView();
            this.clSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.storagesToolStripMenuItem,
            this.publishToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtConfiguration,
            this.mtSQLConfiguration,
            this.mtServers});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // mtConfiguration
            // 
            this.mtConfiguration.Name = "mtConfiguration";
            this.mtConfiguration.Size = new System.Drawing.Size(183, 26);
            this.mtConfiguration.Text = "Configuration";
            this.mtConfiguration.Click += new System.EventHandler(this.mtConfiguration_Click);
            // 
            // mtSQLConfiguration
            // 
            this.mtSQLConfiguration.Name = "mtSQLConfiguration";
            this.mtSQLConfiguration.Size = new System.Drawing.Size(183, 26);
            this.mtSQLConfiguration.Text = "SQL";
            this.mtSQLConfiguration.Click += new System.EventHandler(this.mtSQLConfiguration_Click);
            // 
            // mtServers
            // 
            this.mtServers.Name = "mtServers";
            this.mtServers.Size = new System.Drawing.Size(183, 26);
            this.mtServers.Text = "Servers";
            this.mtServers.Click += new System.EventHandler(this.mtServers_Click);
            // 
            // storagesToolStripMenuItem
            // 
            this.storagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtStoragePublish,
            this.mtStorageStart,
            this.mtStorageDatabase,
            this.mtStorageReplaceAppSetting});
            this.storagesToolStripMenuItem.Name = "storagesToolStripMenuItem";
            this.storagesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.storagesToolStripMenuItem.Text = "Storages";
            // 
            // mtStoragePublish
            // 
            this.mtStoragePublish.Name = "mtStoragePublish";
            this.mtStoragePublish.Size = new System.Drawing.Size(228, 26);
            this.mtStoragePublish.Text = "Publish";
            // 
            // mtStorageStart
            // 
            this.mtStorageStart.Name = "mtStorageStart";
            this.mtStorageStart.Size = new System.Drawing.Size(228, 26);
            this.mtStorageStart.Text = "Start";
            // 
            // mtStorageDatabase
            // 
            this.mtStorageDatabase.Name = "mtStorageDatabase";
            this.mtStorageDatabase.Size = new System.Drawing.Size(228, 26);
            this.mtStorageDatabase.Text = "Database";
            // 
            // mtStorageReplaceAppSetting
            // 
            this.mtStorageReplaceAppSetting.Name = "mtStorageReplaceAppSetting";
            this.mtStorageReplaceAppSetting.Size = new System.Drawing.Size(228, 26);
            this.mtStorageReplaceAppSetting.Text = "Replace App Setting";
            // 
            // publishToolStripMenuItem1
            // 
            this.publishToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtPublishApp,
            this.mtPublishDatabase});
            this.publishToolStripMenuItem1.Name = "publishToolStripMenuItem1";
            this.publishToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.publishToolStripMenuItem1.Text = "Publish";
            // 
            // mtPublishApp
            // 
            this.mtPublishApp.Name = "mtPublishApp";
            this.mtPublishApp.Size = new System.Drawing.Size(155, 26);
            this.mtPublishApp.Text = "App";
            // 
            // mtPublishDatabase
            // 
            this.mtPublishDatabase.Name = "mtPublishDatabase";
            this.mtPublishDatabase.Size = new System.Drawing.Size(155, 26);
            this.mtPublishDatabase.Text = "Database";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSaveSelected);
            this.panel1.Controls.Add(this.btnUncheckAll);
            this.panel1.Controls.Add(this.btnCheckAll);
            this.panel1.Controls.Add(this.btnStopAll);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.cbRunFeatures);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 90);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Location = new System.Drawing.Point(217, 48);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(128, 29);
            this.btnSaveSelected.TabIndex = 6;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(115, 48);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(96, 29);
            this.btnUncheckAll.TabIndex = 5;
            this.btnUncheckAll.Text = "UnCheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(13, 47);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(96, 29);
            this.btnCheckAll.TabIndex = 4;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Location = new System.Drawing.Point(451, 13);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(94, 29);
            this.btnStopAll.TabIndex = 3;
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(351, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(251, 13);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(94, 29);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // cbRunFeatures
            // 
            this.cbRunFeatures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRunFeatures.FormattingEnabled = true;
            this.cbRunFeatures.Location = new System.Drawing.Point(13, 13);
            this.cbRunFeatures.Name = "cbRunFeatures";
            this.cbRunFeatures.Size = new System.Drawing.Size(228, 28);
            this.cbRunFeatures.TabIndex = 0;
            this.cbRunFeatures.SelectedValueChanged += new System.EventHandler(this.cbRunFeatures_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvStart);
            this.panel2.Location = new System.Drawing.Point(12, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 414);
            this.panel2.TabIndex = 2;
            // 
            // dgvStart
            // 
            this.dgvStart.AllowUserToAddRows = false;
            this.dgvStart.AllowUserToDeleteRows = false;
            this.dgvStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSelected,
            this.clId,
            this.clName,
            this.clFileName,
            this.clProcess,
            this.clMessage});
            this.dgvStart.Location = new System.Drawing.Point(3, 3);
            this.dgvStart.Name = "dgvStart";
            this.dgvStart.RowHeadersWidth = 51;
            this.dgvStart.RowTemplate.Height = 29;
            this.dgvStart.Size = new System.Drawing.Size(550, 406);
            this.dgvStart.TabIndex = 0;
            // 
            // clSelected
            // 
            this.clSelected.DataPropertyName = "IsChecked";
            this.clSelected.HeaderText = "";
            this.clSelected.MinimumWidth = 6;
            this.clSelected.Name = "clSelected";
            this.clSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clSelected.Width = 50;
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Id";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.Visible = false;
            this.clId.Width = 125;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Name";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.Width = 125;
            // 
            // clFileName
            // 
            this.clFileName.DataPropertyName = "FileName";
            this.clFileName.HeaderText = "File Name";
            this.clFileName.MinimumWidth = 6;
            this.clFileName.Name = "clFileName";
            this.clFileName.Width = 125;
            // 
            // clProcess
            // 
            this.clProcess.DataPropertyName = "ProcessId";
            this.clProcess.HeaderText = "Process";
            this.clProcess.MinimumWidth = 6;
            this.clProcess.Name = "clProcess";
            this.clProcess.Width = 125;
            // 
            // clMessage
            // 
            this.clMessage.DataPropertyName = "Message";
            this.clMessage.HeaderText = "Message";
            this.clMessage.MinimumWidth = 6;
            this.clMessage.Name = "clMessage";
            this.clMessage.ReadOnly = true;
            this.clMessage.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem mtConfiguration;
        private ToolStripMenuItem mtSQLConfiguration;
        private ToolStripMenuItem mtServers;
        private ToolStripMenuItem storagesToolStripMenuItem;
        private ToolStripMenuItem mtStoragePublish;
        private ToolStripMenuItem mtStorageStart;
        private ToolStripMenuItem mtStorageDatabase;
        private ToolStripMenuItem mtStorageReplaceAppSetting;
        private ToolStripMenuItem publishToolStripMenuItem1;
        private ToolStripMenuItem mtPublishApp;
        private ToolStripMenuItem mtPublishDatabase;
        private Panel panel1;
        private Panel panel2;
        private Button btnStopAll;
        private Button btnStop;
        private Button btnRun;
        private ComboBox cbRunFeatures;
        private Button btnUncheckAll;
        private Button btnCheckAll;
        private DataGridView dgvStart;
        private Button btnSaveSelected;
        private DataGridViewCheckBoxColumn clSelected;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clName;
        private DataGridViewTextBoxColumn clFileName;
        private DataGridViewTextBoxColumn clProcess;
        private DataGridViewTextBoxColumn clMessage;
    }
}
namespace SM.Forms.Forms.Settings
{
    partial class frmConfiguration
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublishFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackupDataFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppConfig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjectFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatabaseProjectFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVsDevCmdPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnVsDevCmdPath = new System.Windows.Forms.Button();
            this.btnProjectFolder = new System.Windows.Forms.Button();
            this.btnDatabaseProjectFolder = new System.Windows.Forms.Button();
            this.btnAzureFuncToolPath = new System.Windows.Forms.Button();
            this.txtAzureFuncToolPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.databaseProjectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openVSDevCmdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAzureFunctionToolFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnMsBuild = new System.Windows.Forms.Button();
            this.txtMsBuild = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openMSBuildFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRevert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(676, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(170, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(550, 27);
            this.txtPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path";
            // 
            // txtPublishFolder
            // 
            this.txtPublishFolder.Location = new System.Drawing.Point(170, 45);
            this.txtPublishFolder.Name = "txtPublishFolder";
            this.txtPublishFolder.ReadOnly = true;
            this.txtPublishFolder.Size = new System.Drawing.Size(550, 27);
            this.txtPublishFolder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publish Folder";
            // 
            // txtBackupDataFolder
            // 
            this.txtBackupDataFolder.Location = new System.Drawing.Point(170, 78);
            this.txtBackupDataFolder.Name = "txtBackupDataFolder";
            this.txtBackupDataFolder.ReadOnly = true;
            this.txtBackupDataFolder.Size = new System.Drawing.Size(550, 27);
            this.txtBackupDataFolder.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Backup Data Folder";
            // 
            // txtAppConfig
            // 
            this.txtAppConfig.Location = new System.Drawing.Point(170, 111);
            this.txtAppConfig.Name = "txtAppConfig";
            this.txtAppConfig.ReadOnly = true;
            this.txtAppConfig.Size = new System.Drawing.Size(550, 27);
            this.txtAppConfig.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "App Config";
            // 
            // txtProjectFolder
            // 
            this.txtProjectFolder.Location = new System.Drawing.Point(170, 144);
            this.txtProjectFolder.Name = "txtProjectFolder";
            this.txtProjectFolder.ReadOnly = true;
            this.txtProjectFolder.Size = new System.Drawing.Size(550, 27);
            this.txtProjectFolder.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Project Folder";
            // 
            // txtDatabaseProjectFolder
            // 
            this.txtDatabaseProjectFolder.Location = new System.Drawing.Point(170, 177);
            this.txtDatabaseProjectFolder.Name = "txtDatabaseProjectFolder";
            this.txtDatabaseProjectFolder.ReadOnly = true;
            this.txtDatabaseProjectFolder.Size = new System.Drawing.Size(550, 27);
            this.txtDatabaseProjectFolder.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Database Project Folder";
            // 
            // txtVsDevCmdPath
            // 
            this.txtVsDevCmdPath.Location = new System.Drawing.Point(170, 210);
            this.txtVsDevCmdPath.Name = "txtVsDevCmdPath";
            this.txtVsDevCmdPath.ReadOnly = true;
            this.txtVsDevCmdPath.Size = new System.Drawing.Size(550, 27);
            this.txtVsDevCmdPath.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "VsDevCmd Path";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(726, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(48, 27);
            this.btnPath.TabIndex = 20;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnVsDevCmdPath
            // 
            this.btnVsDevCmdPath.Location = new System.Drawing.Point(726, 210);
            this.btnVsDevCmdPath.Name = "btnVsDevCmdPath";
            this.btnVsDevCmdPath.Size = new System.Drawing.Size(48, 27);
            this.btnVsDevCmdPath.TabIndex = 21;
            this.btnVsDevCmdPath.Text = "...";
            this.btnVsDevCmdPath.UseVisualStyleBackColor = true;
            this.btnVsDevCmdPath.Click += new System.EventHandler(this.btnVsDevCmdPath_Click);
            // 
            // btnProjectFolder
            // 
            this.btnProjectFolder.Location = new System.Drawing.Point(726, 144);
            this.btnProjectFolder.Name = "btnProjectFolder";
            this.btnProjectFolder.Size = new System.Drawing.Size(48, 27);
            this.btnProjectFolder.TabIndex = 22;
            this.btnProjectFolder.Text = "...";
            this.btnProjectFolder.UseVisualStyleBackColor = true;
            this.btnProjectFolder.Click += new System.EventHandler(this.btnProjectFolder_Click);
            // 
            // btnDatabaseProjectFolder
            // 
            this.btnDatabaseProjectFolder.Location = new System.Drawing.Point(726, 177);
            this.btnDatabaseProjectFolder.Name = "btnDatabaseProjectFolder";
            this.btnDatabaseProjectFolder.Size = new System.Drawing.Size(48, 27);
            this.btnDatabaseProjectFolder.TabIndex = 23;
            this.btnDatabaseProjectFolder.Text = "...";
            this.btnDatabaseProjectFolder.UseVisualStyleBackColor = true;
            this.btnDatabaseProjectFolder.Click += new System.EventHandler(this.btnDatabaseProjectFolder_Click);
            // 
            // btnAzureFuncToolPath
            // 
            this.btnAzureFuncToolPath.Location = new System.Drawing.Point(726, 243);
            this.btnAzureFuncToolPath.Name = "btnAzureFuncToolPath";
            this.btnAzureFuncToolPath.Size = new System.Drawing.Size(48, 27);
            this.btnAzureFuncToolPath.TabIndex = 26;
            this.btnAzureFuncToolPath.Text = "...";
            this.btnAzureFuncToolPath.UseVisualStyleBackColor = true;
            this.btnAzureFuncToolPath.Click += new System.EventHandler(this.btnAzureFuncToolPath_Click);
            // 
            // txtAzureFuncToolPath
            // 
            this.txtAzureFuncToolPath.Location = new System.Drawing.Point(170, 243);
            this.txtAzureFuncToolPath.Name = "txtAzureFuncToolPath";
            this.txtAzureFuncToolPath.ReadOnly = true;
            this.txtAzureFuncToolPath.Size = new System.Drawing.Size(550, 27);
            this.txtAzureFuncToolPath.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Azure Func Tool Path";
            // 
            // openVSDevCmdFileDialog
            // 
            this.openVSDevCmdFileDialog.FileName = "openVSDevCmdFileDialog";
            // 
            // openAzureFunctionToolFileDialog
            // 
            this.openAzureFunctionToolFileDialog.FileName = "openAzureFunctionToolFileDialog";
            // 
            // btnMsBuild
            // 
            this.btnMsBuild.Location = new System.Drawing.Point(726, 276);
            this.btnMsBuild.Name = "btnMsBuild";
            this.btnMsBuild.Size = new System.Drawing.Size(48, 27);
            this.btnMsBuild.TabIndex = 30;
            this.btnMsBuild.Text = "...";
            this.btnMsBuild.UseVisualStyleBackColor = true;
            this.btnMsBuild.Click += new System.EventHandler(this.btnMsBuild_Click);
            // 
            // txtMsBuild
            // 
            this.txtMsBuild.Location = new System.Drawing.Point(170, 276);
            this.txtMsBuild.Name = "txtMsBuild";
            this.txtMsBuild.ReadOnly = true;
            this.txtMsBuild.Size = new System.Drawing.Size(550, 27);
            this.txtMsBuild.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "MsBuild";
            // 
            // openMSBuildFileDialog
            // 
            this.openMSBuildFileDialog.FileName = "openMSBuildFileDialog";
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(576, 412);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(94, 29);
            this.btnRevert.TabIndex = 31;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Visible = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnMsBuild);
            this.Controls.Add(this.txtMsBuild);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAzureFuncToolPath);
            this.Controls.Add(this.txtAzureFuncToolPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDatabaseProjectFolder);
            this.Controls.Add(this.btnProjectFolder);
            this.Controls.Add(this.btnVsDevCmdPath);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtVsDevCmdPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDatabaseProjectFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProjectFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAppConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBackupDataFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPublishFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private TextBox txtPath;
        private Label label1;
        private TextBox txtPublishFolder;
        private Label label2;
        private TextBox txtBackupDataFolder;
        private Label label3;
        private TextBox txtAppConfig;
        private Label label4;
        private TextBox txtProjectFolder;
        private Label label5;
        private TextBox txtDatabaseProjectFolder;
        private Label label6;
        private TextBox txtVsDevCmdPath;
        private Label label7;
        private Button btnPath;
        private Button btnVsDevCmdPath;
        private Button btnProjectFolder;
        private Button btnDatabaseProjectFolder;
        private Button btnAzureFuncToolPath;
        private TextBox txtAzureFuncToolPath;
        private Label label8;
        private FolderBrowserDialog pathBrowserDialog;
        private FolderBrowserDialog projectFolderBrowserDialog;
        private FolderBrowserDialog databaseProjectFolderBrowserDialog;
        private OpenFileDialog openVSDevCmdFileDialog;
        private OpenFileDialog openAzureFunctionToolFileDialog;
        private Button btnMsBuild;
        private TextBox txtMsBuild;
        private Label label9;
        private OpenFileDialog openMSBuildFileDialog;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip9;
        private Button btnRevert;
    }
}
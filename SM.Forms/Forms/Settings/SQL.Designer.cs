namespace SM.Forms.Forms.Settings
{
    partial class frmSQL
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtSQMCMD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLServerSolution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkingpaperDACPAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoreDACPAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCatalogDACPAC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeployEnv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSQLPackage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSQLCMD = new System.Windows.Forms.Button();
            this.btnSQLPackage = new System.Windows.Forms.Button();
            this.btnDeployEnv = new System.Windows.Forms.Button();
            this.btnSQLServerSolution = new System.Windows.Forms.Button();
            this.btnCatalogDACPAC = new System.Windows.Forms.Button();
            this.btnCoreDACPAC = new System.Windows.Forms.Button();
            this.btnWorkingpaperDACPAC = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(170, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(550, 27);
            this.txtPath.TabIndex = 2;
            // 
            // txtSQMCMD
            // 
            this.txtSQMCMD.Location = new System.Drawing.Point(170, 45);
            this.txtSQMCMD.Name = "txtSQMCMD";
            this.txtSQMCMD.ReadOnly = true;
            this.txtSQMCMD.Size = new System.Drawing.Size(550, 27);
            this.txtSQMCMD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SQLCMD";
            // 
            // txtSQLServerSolution
            // 
            this.txtSQLServerSolution.Location = new System.Drawing.Point(170, 78);
            this.txtSQLServerSolution.Name = "txtSQLServerSolution";
            this.txtSQLServerSolution.ReadOnly = true;
            this.txtSQLServerSolution.Size = new System.Drawing.Size(550, 27);
            this.txtSQLServerSolution.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SQL Server Solution";
            // 
            // txtWorkingpaperDACPAC
            // 
            this.txtWorkingpaperDACPAC.Location = new System.Drawing.Point(170, 177);
            this.txtWorkingpaperDACPAC.Name = "txtWorkingpaperDACPAC";
            this.txtWorkingpaperDACPAC.ReadOnly = true;
            this.txtWorkingpaperDACPAC.Size = new System.Drawing.Size(550, 27);
            this.txtWorkingpaperDACPAC.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Workingpaper DACPAC";
            // 
            // txtCoreDACPAC
            // 
            this.txtCoreDACPAC.Location = new System.Drawing.Point(170, 144);
            this.txtCoreDACPAC.Name = "txtCoreDACPAC";
            this.txtCoreDACPAC.ReadOnly = true;
            this.txtCoreDACPAC.Size = new System.Drawing.Size(550, 27);
            this.txtCoreDACPAC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Core DACPAC";
            // 
            // txtCatalogDACPAC
            // 
            this.txtCatalogDACPAC.Location = new System.Drawing.Point(170, 111);
            this.txtCatalogDACPAC.Name = "txtCatalogDACPAC";
            this.txtCatalogDACPAC.ReadOnly = true;
            this.txtCatalogDACPAC.Size = new System.Drawing.Size(550, 27);
            this.txtCatalogDACPAC.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Catalog DACPAC";
            // 
            // txtDeployEnv
            // 
            this.txtDeployEnv.Location = new System.Drawing.Point(170, 243);
            this.txtDeployEnv.Name = "txtDeployEnv";
            this.txtDeployEnv.ReadOnly = true;
            this.txtDeployEnv.Size = new System.Drawing.Size(550, 27);
            this.txtDeployEnv.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Deploy Env";
            // 
            // txtSQLPackage
            // 
            this.txtSQLPackage.Location = new System.Drawing.Point(170, 210);
            this.txtSQLPackage.Name = "txtSQLPackage";
            this.txtSQLPackage.ReadOnly = true;
            this.txtSQLPackage.Size = new System.Drawing.Size(550, 27);
            this.txtSQLPackage.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "SQL Package";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(726, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(48, 27);
            this.btnPath.TabIndex = 19;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // btnSQLCMD
            // 
            this.btnSQLCMD.Location = new System.Drawing.Point(726, 45);
            this.btnSQLCMD.Name = "btnSQLCMD";
            this.btnSQLCMD.Size = new System.Drawing.Size(48, 27);
            this.btnSQLCMD.TabIndex = 20;
            this.btnSQLCMD.Text = "...";
            this.btnSQLCMD.UseVisualStyleBackColor = true;
            // 
            // btnSQLPackage
            // 
            this.btnSQLPackage.Location = new System.Drawing.Point(726, 210);
            this.btnSQLPackage.Name = "btnSQLPackage";
            this.btnSQLPackage.Size = new System.Drawing.Size(48, 27);
            this.btnSQLPackage.TabIndex = 21;
            this.btnSQLPackage.Text = "...";
            this.btnSQLPackage.UseVisualStyleBackColor = true;
            // 
            // btnDeployEnv
            // 
            this.btnDeployEnv.Location = new System.Drawing.Point(726, 243);
            this.btnDeployEnv.Name = "btnDeployEnv";
            this.btnDeployEnv.Size = new System.Drawing.Size(48, 27);
            this.btnDeployEnv.TabIndex = 22;
            this.btnDeployEnv.Text = "...";
            this.btnDeployEnv.UseVisualStyleBackColor = true;
            // 
            // btnSQLServerSolution
            // 
            this.btnSQLServerSolution.Location = new System.Drawing.Point(726, 78);
            this.btnSQLServerSolution.Name = "btnSQLServerSolution";
            this.btnSQLServerSolution.Size = new System.Drawing.Size(48, 27);
            this.btnSQLServerSolution.TabIndex = 24;
            this.btnSQLServerSolution.Text = "...";
            this.btnSQLServerSolution.UseVisualStyleBackColor = true;
            // 
            // btnCatalogDACPAC
            // 
            this.btnCatalogDACPAC.Location = new System.Drawing.Point(726, 111);
            this.btnCatalogDACPAC.Name = "btnCatalogDACPAC";
            this.btnCatalogDACPAC.Size = new System.Drawing.Size(48, 27);
            this.btnCatalogDACPAC.TabIndex = 25;
            this.btnCatalogDACPAC.Text = "...";
            this.btnCatalogDACPAC.UseVisualStyleBackColor = true;
            // 
            // btnCoreDACPAC
            // 
            this.btnCoreDACPAC.Location = new System.Drawing.Point(726, 144);
            this.btnCoreDACPAC.Name = "btnCoreDACPAC";
            this.btnCoreDACPAC.Size = new System.Drawing.Size(48, 27);
            this.btnCoreDACPAC.TabIndex = 26;
            this.btnCoreDACPAC.Text = "...";
            this.btnCoreDACPAC.UseVisualStyleBackColor = true;
            // 
            // btnWorkingpaperDACPAC
            // 
            this.btnWorkingpaperDACPAC.Location = new System.Drawing.Point(726, 177);
            this.btnWorkingpaperDACPAC.Name = "btnWorkingpaperDACPAC";
            this.btnWorkingpaperDACPAC.Size = new System.Drawing.Size(48, 27);
            this.btnWorkingpaperDACPAC.TabIndex = 27;
            this.btnWorkingpaperDACPAC.Text = "...";
            this.btnWorkingpaperDACPAC.UseVisualStyleBackColor = true;
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnWorkingpaperDACPAC);
            this.Controls.Add(this.btnCoreDACPAC);
            this.Controls.Add(this.btnCatalogDACPAC);
            this.Controls.Add(this.btnSQLServerSolution);
            this.Controls.Add(this.btnDeployEnv);
            this.Controls.Add(this.btnSQLPackage);
            this.Controls.Add(this.btnSQLCMD);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtDeployEnv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSQLPackage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWorkingpaperDACPAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoreDACPAC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCatalogDACPAC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSQLServerSolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSQMCMD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtPath;
        private TextBox txtSQMCMD;
        private Label label2;
        private TextBox txtSQLServerSolution;
        private Label label3;
        private TextBox txtWorkingpaperDACPAC;
        private Label label4;
        private TextBox txtCoreDACPAC;
        private Label label5;
        private TextBox txtCatalogDACPAC;
        private Label label6;
        private TextBox txtDeployEnv;
        private Label label8;
        private TextBox txtSQLPackage;
        private Label label9;
        private Button btnPath;
        private Button btnSQLCMD;
        private Button btnSQLPackage;
        private Button btnDeployEnv;
        private Button btnSQLServerSolution;
        private Button btnCatalogDACPAC;
        private Button btnCoreDACPAC;
        private Button btnWorkingpaperDACPAC;
    }
}
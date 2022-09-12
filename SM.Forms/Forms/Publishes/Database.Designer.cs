namespace SM.Forms.Forms.Publishes
{
    partial class frmDatabase
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
            this.pnItems = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDrop = new System.Windows.Forms.RadioButton();
            this.rdbRestore = new System.Windows.Forms.RadioButton();
            this.rdbBackup = new System.Windows.Forms.RadioButton();
            this.rdbMigrate = new System.Windows.Forms.RadioButton();
            this.rdbDeploy = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnItems
            // 
            this.pnItems.AutoScroll = true;
            this.pnItems.Location = new System.Drawing.Point(12, 76);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(758, 365);
            this.pnItems.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDrop);
            this.groupBox1.Controls.Add(this.rdbRestore);
            this.groupBox1.Controls.Add(this.rdbBackup);
            this.groupBox1.Controls.Add(this.rdbMigrate);
            this.groupBox1.Controls.Add(this.rdbDeploy);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rdbDrop
            // 
            this.rdbDrop.AutoSize = true;
            this.rdbDrop.Location = new System.Drawing.Point(348, 26);
            this.rdbDrop.Name = "rdbDrop";
            this.rdbDrop.Size = new System.Drawing.Size(64, 24);
            this.rdbDrop.TabIndex = 4;
            this.rdbDrop.TabStop = true;
            this.rdbDrop.Text = "Drop";
            this.rdbDrop.UseVisualStyleBackColor = true;
            // 
            // rdbRestore
            // 
            this.rdbRestore.AutoSize = true;
            this.rdbRestore.Location = new System.Drawing.Point(262, 26);
            this.rdbRestore.Name = "rdbRestore";
            this.rdbRestore.Size = new System.Drawing.Size(80, 24);
            this.rdbRestore.TabIndex = 3;
            this.rdbRestore.TabStop = true;
            this.rdbRestore.Text = "Restore";
            this.rdbRestore.UseVisualStyleBackColor = true;
            // 
            // rdbBackup
            // 
            this.rdbBackup.AutoSize = true;
            this.rdbBackup.Location = new System.Drawing.Point(178, 26);
            this.rdbBackup.Name = "rdbBackup";
            this.rdbBackup.Size = new System.Drawing.Size(78, 24);
            this.rdbBackup.TabIndex = 2;
            this.rdbBackup.TabStop = true;
            this.rdbBackup.Text = "Backup";
            this.rdbBackup.UseVisualStyleBackColor = true;
            // 
            // rdbMigrate
            // 
            this.rdbMigrate.AutoSize = true;
            this.rdbMigrate.Location = new System.Drawing.Point(90, 26);
            this.rdbMigrate.Name = "rdbMigrate";
            this.rdbMigrate.Size = new System.Drawing.Size(82, 24);
            this.rdbMigrate.TabIndex = 1;
            this.rdbMigrate.TabStop = true;
            this.rdbMigrate.Text = "Migrate";
            this.rdbMigrate.UseVisualStyleBackColor = true;
            // 
            // rdbDeploy
            // 
            this.rdbDeploy.AutoSize = true;
            this.rdbDeploy.Location = new System.Drawing.Point(6, 26);
            this.rdbDeploy.Name = "rdbDeploy";
            this.rdbDeploy.Size = new System.Drawing.Size(78, 24);
            this.rdbDeploy.TabIndex = 0;
            this.rdbDeploy.TabStop = true;
            this.rdbDeploy.Text = "Deploy";
            this.rdbDeploy.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(615, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(155, 55);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pnItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnItems;
        private GroupBox groupBox1;
        private RadioButton rdbDrop;
        private RadioButton rdbRestore;
        private RadioButton rdbBackup;
        private RadioButton rdbMigrate;
        private RadioButton rdbDeploy;
        private Button btnRun;
    }
}
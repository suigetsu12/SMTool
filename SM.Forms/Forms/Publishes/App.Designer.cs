namespace SM.Forms.Forms.Publishes
{
    partial class frmApp
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
            this.rdbFunction = new System.Windows.Forms.RadioButton();
            this.rdbFeature = new System.Windows.Forms.RadioButton();
            this.btnPublish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnItems
            // 
            this.pnItems.AutoScroll = true;
            this.pnItems.Location = new System.Drawing.Point(12, 79);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(758, 365);
            this.pnItems.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFunction);
            this.groupBox1.Controls.Add(this.rdbFeature);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdbFunction
            // 
            this.rdbFunction.AutoSize = true;
            this.rdbFunction.Location = new System.Drawing.Point(116, 26);
            this.rdbFunction.Name = "rdbFunction";
            this.rdbFunction.Size = new System.Drawing.Size(86, 24);
            this.rdbFunction.TabIndex = 1;
            this.rdbFunction.TabStop = true;
            this.rdbFunction.Text = "Function";
            this.rdbFunction.UseVisualStyleBackColor = true;
            // 
            // rdbFeature
            // 
            this.rdbFeature.AutoSize = true;
            this.rdbFeature.Location = new System.Drawing.Point(20, 26);
            this.rdbFeature.Name = "rdbFeature";
            this.rdbFeature.Size = new System.Drawing.Size(79, 24);
            this.rdbFeature.TabIndex = 0;
            this.rdbFeature.TabStop = true;
            this.rdbFeature.Text = "Feature";
            this.rdbFeature.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPublish.Enabled = false;
            this.btnPublish.Location = new System.Drawing.Point(620, 18);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(150, 55);
            this.btnPublish.TabIndex = 5;
            this.btnPublish.Text = "Run";
            this.btnPublish.UseVisualStyleBackColor = false;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pnItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPublish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnItems;
        private GroupBox groupBox1;
        private RadioButton rdbFunction;
        private RadioButton rdbFeature;
        private Button btnPublish;
    }
}
using SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.Forms.Forms.Settings
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
            SetToolTip();
            RenderData();
        }

        private void SetToolTip()
        {
            toolTip1.SetToolTip(label1, "Path of the main folder");
            toolTip2.SetToolTip(label2, "Path of the publish folder related to the main folder");
            toolTip3.SetToolTip(label3, "Path of the backup data folder related to the main folder");
            toolTip4.SetToolTip(label4, "App config name");
            toolTip5.SetToolTip(label5, "Path of the project folder");
            toolTip6.SetToolTip(label6, "Path of the database project folder");
            toolTip7.SetToolTip(label7, "Path of the .bat file Visual Studio Dev Command-Line");
            toolTip8.SetToolTip(label8, "Path of the .exe file Azure Function tool");
            toolTip9.SetToolTip(label9, "Path of the .exe file MSBuild");
        }

        private void RenderData()
        {
            string path = Global.Configuration.Path;
            txtPath.Text = path;
            txtPublishFolder.Text = Path.Combine(path, Global.Configuration.PublishFolder);
            txtBackupDataFolder.Text = Path.Combine(path, Global.Configuration.BackupDataFolder);
            txtAppConfig.Text = Global.Configuration.AppConfig;
            txtProjectFolder.Text = Global.Configuration.ProjectFolder;
            txtDatabaseProjectFolder.Text = Global.Configuration.DatabaseProjectFolder;
            txtVsDevCmdPath.Text = Global.Configuration.VsDevCmdPath;
            txtMsBuild.Text = Global.Configuration.MSBuildPath;
            txtAzureFuncToolPath.Text = Global.Configuration.AzureFuncToolPath;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            ChoosePathFolder();
        }

        private void btnProjectFolder_Click(object sender, EventArgs e)
        {
            ChooseProjectFolder();
        }

        private void btnDatabaseProjectFolder_Click(object sender, EventArgs e)
        {
            ChooseDatabaseProjectFolder();
        }

        private void btnVsDevCmdPath_Click(object sender, EventArgs e)
        {
            ChooseVSDevCmdFile();
        }

        private void btnAzureFuncToolPath_Click(object sender, EventArgs e)
        {
            ChooseAzureFuncToolFile();
        }

        private void btnMsBuild_Click(object sender, EventArgs e)
        {
            ChooseMSBuildFile();
        }
        #region [Browser Folder Dialog]
        private void ChoosePathFolder()
        {
            pathBrowserDialog.SelectedPath = txtPath.Text ?? Global.Configuration.Path;
            if (pathBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = pathBrowserDialog.SelectedPath;
                txtPath.Text = newPath;
                txtPublishFolder.Text = Path.Combine(newPath, Global.Configuration.PublishFolder);
                txtBackupDataFolder.Text = Path.Combine(newPath, Global.Configuration.BackupDataFolder);
                btnRevert.Visible = true;
            }
        }

        private void ChooseProjectFolder()
        {
            projectFolderBrowserDialog.SelectedPath = txtProjectFolder.Text ?? Global.Configuration.ProjectFolder;
            if (projectFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = projectFolderBrowserDialog.SelectedPath;
                txtProjectFolder.Text = newPath;
                btnRevert.Visible = true;
            }
        }

        private void ChooseDatabaseProjectFolder()
        {
            databaseProjectFolderBrowserDialog.SelectedPath = txtDatabaseProjectFolder.Text ?? Global.Configuration.DatabaseProjectFolder;
            if (databaseProjectFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = databaseProjectFolderBrowserDialog.SelectedPath;
                txtDatabaseProjectFolder.Text = newPath;
                btnRevert.Visible = true;
            }
        }
        #endregion

        #region [Browser File Dialog]
        private void ChooseVSDevCmdFile()
        {
            if (openVSDevCmdFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = openVSDevCmdFileDialog.FileName;
                txtVsDevCmdPath.Text = newPath;
                btnRevert.Visible = true;
            }
        }

        private void ChooseAzureFuncToolFile()
        {
            if (openAzureFunctionToolFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = openAzureFunctionToolFileDialog.FileName;
                txtAzureFuncToolPath.Text = newPath;
                btnRevert.Visible = true;
            }
        }
        private void ChooseMSBuildFile()
        {
            if (openMSBuildFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = openMSBuildFileDialog.FileName;
                txtMsBuild.Text = newPath;
                btnRevert.Visible = true;
            }
        }
        #endregion

        private void btnRevert_Click(object sender, EventArgs e)
        {
            RenderData();
            btnRevert.Visible = false;
        }
    }
}

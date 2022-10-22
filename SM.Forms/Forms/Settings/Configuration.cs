using SM.Models;
using SM.Models.Configuration;
using SM.Services;
using SM.Shared.Constants;
using SM.Shared.Extensions;
using SM.Shared.Helpers;
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
        private StringRenderService _stringRenderService = new StringRenderService();
        private ServerModel mainServer = new ServerModel();
        private ServerModel cfServer = new ServerModel();
        public frmConfiguration()
        {
            InitializeComponent();
            LoadServerData();
            SetToolTip();
            RenderData();
        }

        private void SetToolTip()
        {
            toolTip1.SetToolTip(label1, "Path of the main folder");
            toolTip2.SetToolTip(label2, "Path of the publish folder related to the main folder");
            toolTip3.SetToolTip(label3, "Path of the backup data folder related to the main folder");
            toolTip5.SetToolTip(label5, "Path of the project folder");
            toolTip6.SetToolTip(label6, "Path of the database project folder");
            toolTip7.SetToolTip(label7, "Path of the .bat file Visual Studio Dev Command-Line");
            toolTip8.SetToolTip(label8, "Path of the .exe file Azure Function tool");
            toolTip9.SetToolTip(label9, "Path of the .exe file MSBuild");
            toolTip4.SetToolTip(label4, "Path of the .exe file SQLCMD");
            toolTip11.SetToolTip(label11, "Path of the .exe file SqlPackage");
        }

        private void LoadServerData()
        {
            string mainSvPath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Main);
            string cfSvPath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Cf);
            string jsonMainString = FileHelper.ReadFile(mainSvPath);
            if (jsonMainString.NotNullOrEmpty())
            {
                mainServer = JsonHelper.Deserialize<ServerModel>(jsonMainString);
            }
            string jsonCFString = FileHelper.ReadFile(cfSvPath);
            if (jsonCFString.NotNullOrEmpty())
            {
                cfServer = JsonHelper.Deserialize<ServerModel>(jsonCFString);
            }
        }

        private void RenderData()
        {
            #region [General]
            string path = Global.Configuration.Path;
            txtPath.Text = path;
            txtPublishFolder.Text = Path.Combine(path, Global.Configuration.PublishFolder);
            txtBackupDataFolder.Text = Path.Combine(path, Global.Configuration.BackupDataFolder);
            txtProjectFolder.Text = Global.Configuration.ProjectFolder;
            txtDatabaseProjectFolder.Text = Global.Configuration.DatabaseProjectFolder;
            txtVsDevCmdPath.Text = Global.Configuration.VsDevCmdPath;
            txtMsBuild.Text = Global.Configuration.MSBuildPath;
            txtAzureFuncToolPath.Text = Global.Configuration.AzureFuncToolPath;
            txtSQLCMD.Text = Global.Configuration.SQLCMD;
            txtSQLPackage.Text = Global.Configuration.SQLPackage;
            #endregion

            #region [Server]
            #region [Main]
            txtServerMain.Text = mainServer.Server;
            txtUserMain.Text = mainServer.Login;
            txtPasswordMain.Text = mainServer.Password;
            txtPortMain.Text = mainServer.Port;
            txtGeoMain.Text = mainServer.GEO;
            txtGeoPasswordMain.Text = mainServer.GEOPassword;
            txtUserContainerCodeMain.Text = mainServer.UserContainerCode;
            txtContainerCodeMain.Text = mainServer.ContainerCode;
            txtContainerPasswordMain.Text = mainServer.ContainerPassword;
            txtDeployEnvMain.Text = mainServer.DeployEnv;
            #endregion

            #region [CF]
            txtServerCF.Text = cfServer.Server;
            txtUserCF.Text = cfServer.Login;
            txtPasswordCF.Text = cfServer.Password;
            txtPortCF.Text = cfServer.Port;
            txtGeoCF.Text = cfServer.GEO;
            txtGeoPasswordCF.Text = cfServer.GEOPassword;
            txtUserContainerCodeCF.Text = cfServer.UserContainerCode;
            txtContainerCodeCF.Text = cfServer.ContainerCode;
            txtContainerPasswordCF.Text = cfServer.ContainerPassword;
            txtDeployEnvCF.Text = cfServer.DeployEnv;
            #endregion
            #endregion

        }

        #region [Browser Button]
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

        private void btnSQLCMD_Click(object sender, EventArgs e)
        {
            ChooseSQLCMDFile();
        }

        private void btnSQLPackage_Click(object sender, EventArgs e)
        {
            ChooseSQLPackageFile();
        }
        #endregion

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

        private void ChooseSQLCMDFile()
        {
            if (openSQLCMDFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = openSQLCMDFileDialog.FileName;
                txtSQLCMD.Text = newPath;
                btnRevert.Visible = true;
            }
        }

        private void ChooseSQLPackageFile()
        {
            if (openSQLPackageFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newPath = openSQLPackageFileDialog.FileName;
                txtSQLPackage.Text = newPath;
                btnRevert.Visible = true;
            }
        }
        #endregion

        private void btnRevert_Click(object sender, EventArgs e)
        {
            RenderData();
            btnRevert.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var message = Validation();
            if (message.NotNullOrEmpty())
            {
                MessageBox.Show(message);
                return;
            }

            #region [General]
            Global.Configuration.Path = txtPath.Text;
            Global.Configuration.BackupDataFolder = Path.Combine(Global.Configuration.Path, FolderConstants.BackupDataFolder);
            Global.Configuration.PublishFolder = Path.Combine(Global.Configuration.Path, FolderConstants.PublishFolder);
            Global.Configuration.ProjectFolder = txtProjectFolder.Text;
            Global.Configuration.DatabaseProjectFolder = txtDatabaseProjectFolder.Text;
            Global.Configuration.VsDevCmdPath = txtVsDevCmdPath.Text;
            Global.Configuration.MSBuildPath = txtMsBuild.Text;
            Global.Configuration.AzureFuncToolPath = txtAzureFuncToolPath.Text;
            Global.Configuration.SQLCMD = txtSQLCMD.Text;
            Global.Configuration.SQLPackage = txtSQLPackage.Text;
            #endregion

            #region [Server]
            #region [Main]
            mainServer.Server = txtServerMain.Text.Trim();
            mainServer.Login = txtUserMain.Text.Trim();
            mainServer.Password = txtPasswordMain.Text.Trim();
            mainServer.Port = txtPortMain.Text.Trim();
            mainServer.GEO = txtGeoMain.Text.Trim();
            mainServer.GEOPassword = txtGeoPasswordMain.Text.Trim();
            mainServer.UserContainerCode = txtUserContainerCodeMain.Text.Trim();
            mainServer.ContainerPassword = txtContainerPasswordMain.Text.Trim();
            mainServer.ContainerCode = txtContainerCodeMain.Text.Trim();
            mainServer.DeployEnv = txtDeployEnvMain.Text.Trim();
            #endregion

            #region [CF]
            cfServer.Server = txtServerCF.Text.Trim();
            cfServer.Login = txtUserCF.Text.Trim();
            cfServer.Password = txtPasswordCF.Text.Trim();
            cfServer.Port = txtPortCF.Text.Trim();
            cfServer.GEO = txtGeoCF.Text.Trim();
            cfServer.GEOPassword = txtGeoPasswordCF.Text.Trim();
            cfServer.UserContainerCode = txtUserContainerCodeCF.Text.Trim();
            cfServer.ContainerPassword = txtContainerPasswordCF.Text.Trim();
            cfServer.ContainerCode = txtContainerCodeCF.Text.Trim();
            cfServer.DeployEnv = txtDeployEnvCF.Text.Trim();
            #endregion
            #endregion

            if (SaveSetting())
            {
                btnRevert.Visible = false;
                UpdatePathConfiguration();
                UpdateConfiguration();
                UpdateServerConfiguration();
                CreateFolder();
                MessageBox.Show(MessageConstans.Success);
            }
            else
            {
                MessageBox.Show(MessageConstans.Failed);
            }
        }

        private void UpdateConfiguration()
        {
            var strMainData = _stringRenderService.RenderConfiguration(Global.Configuration, mainServer);
            FileHelper.WriteFile(Path.Combine(Global.RootAppFolderPath, PathConstants.Bat_Main_Config), strMainData);

            var strCFData = _stringRenderService.RenderConfiguration(Global.Configuration, cfServer);
            FileHelper.WriteFile(Path.Combine(Global.RootAppFolderPath, PathConstants.Bat_CF_Config), strCFData);
        }

        private void UpdateServerConfiguration()
        {
            var strMainData = _stringRenderService.RenderServerConfiguration(Global.Configuration, mainServer);
            FileHelper.WriteFile(Path.Combine(Global.RootAppFolderPath, PathConstants.Bat_Main_Server_Config), strMainData);

            var strCFData = _stringRenderService.RenderServerConfiguration(Global.Configuration, cfServer);
            FileHelper.WriteFile(Path.Combine(Global.RootAppFolderPath, PathConstants.Bat_CF_Server_Config), strCFData);
        }

        private void UpdatePathConfiguration()
        {
            var strData = _stringRenderService.RenderPathConfiguration(Global.Configuration);
            FileHelper.WriteFile(Path.Combine(Global.RootAppFolderPath, PathConstants.Bat_Path), strData);
        }

        private bool SaveSetting()
        {
            var jsonData = JsonHelper.Serializer(Global.Configuration);
            return FileHelper.WriteFile(Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Setting), jsonData);
        }

        private string Validation()
        {
            #region [General]
            if (!txtPath.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "folder path");
            if (!txtPublishFolder.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "publish folder path");
            if (!txtBackupDataFolder.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "database folder path");
            if (!txtProjectFolder.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "project application folder path");
            if (!txtDatabaseProjectFolder.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "project database folder path");
            if (!txtVsDevCmdPath.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "VSDev Cmd path");
            if (!txtAzureFuncToolPath.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "Azure Function tool path");
            if (!txtMsBuild.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "MSBuild path");
            if (!txtSQLCMD.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "SQLCMD path");
            if (!txtSQLPackage.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "SQL Package path");
            #endregion

            #region [Server]
            #region [Main]
            if (!txtServerMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "server main server");
            if (!txtUserMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "user main server");
            if (!txtPasswordMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "password main server");
            if (!txtPortMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "port main server");
            if (!txtGeoMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "geo main server");
            if (!txtGeoPasswordMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "geo password main server");
            if (!txtUserContainerCodeMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "user container code main server");
            if (!txtContainerPasswordMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "container password main server");
            if (!txtContainerCodeMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "container code main server");
            if (!txtDeployEnvMain.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "Deploy Env main server");
            #endregion

            #region [CF]
            if (!txtServerCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "server cf server");
            if (!txtUserCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "user cf server");
            if (!txtPasswordCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "password cf server");
            if (!txtPortCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "port cf server");
            if (!txtGeoCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "geo cf server");
            if (!txtGeoPasswordCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "geo password cf server");
            if (!txtUserContainerCodeCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "user container code cf server");
            if (!txtContainerPasswordCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "container password cf server");
            if (!txtContainerCodeCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "container code cf server");
            if (!txtDeployEnvCF.Text.NotNullOrEmpty())
                return String.Format(MessageConstans.TheFieldEmpty, "Deploy Env cf server");
            #endregion
            #endregion
            return string.Empty;
        }

        private void CreateFolder()
        {
            FolderHelper.CreateFolder(Path.Combine(Global.Configuration.Path, Global.Configuration.PublishFolder));
            FolderHelper.CreateFolder(Path.Combine(Global.Configuration.Path, Global.Configuration.BackupDataFolder));
        }
    }
}

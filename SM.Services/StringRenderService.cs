using SM.Models.Configuration;
using SM.Shared.Constants;
using SM.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Services
{
    public class StringRenderService
    {
        public string RenderPathConfiguration(SettingModel setting)
        {
            List<string> strList = new List<string>();
            strList.Add($"@echo off ");
            strList.Add($"");
            strList.Add($":: --------------------------- The PATH of project  ----------------------------------------");
            strList.Add($"");
            strList.Add($"set rootPathProject={setting.ProjectFolder}\\");
            strList.Add($"");
            strList.Add($":: --------------------------- The PATH of Visual Studio  ----------------------------------------");
            strList.Add($"");
            strList.Add($"set msbuildPath={StringHelper.RefactorPathContainSpace(setting.VsDevCmdPath)}");
            strList.Add($"");
            strList.Add($":: --------------------------- The PATH you want to build to   ----------------------------------------");
            strList.Add($"");
            strList.Add($"set rootPathStart={setting.PublishFolder}\\");
            strList.Add($"");
            strList.Add($":: --------------------------- The PATH Azure function tool   ----------------------------------------");
            strList.Add($"");
            strList.Add($"set azureFunctionToolPath={StringHelper.RefactorPathContainSpace(setting.AzureFuncToolPath)}");
            string stringData = string.Join('\n', strList.ToArray());
            return stringData;
        }

        public string RenderConfiguration(SettingModel setting, ServerModel server)
        {
            List<string> strList = new List<string>();
            strList.Add($"SET SQLCMD=\"{setting.SQLCMD}\"");
            strList.Add($"");
            strList.Add($"SET PATH={setting.BackupDataFolder}\\");
            strList.Add($"");
            strList.Add($"SET SERVER=\"{server.Server}\"");
            strList.Add($"");
            strList.Add($"SET DB=\"master\"");
            strList.Add($"");
            strList.Add($"SET LOGIN=\"{server.Login}\"");
            strList.Add($"");
            strList.Add($"SET PASSWORD=\"{server.Password}\"");
            string stringData = string.Join('\n', strList.ToArray());
            return stringData;
        }

        public string RenderServerConfiguration(SettingModel setting, ServerModel server)
        {
            List<string> strList = new List<string>();
            strList.Add($"set deployenv=\"{server.DeployEnv}\"");
            strList.Add($"");
            strList.Add($"set MSBuild=\"{setting.MSBuildPath}\"");
            strList.Add($"");
            strList.Add($"set SQLServerSolution=\"{StringHelper.RefactorPathContainSpace(Path.Combine(setting.DatabaseProjectFolder, FileConstants.SQLSolution))}\"");
            strList.Add($"");
            strList.Add($"set Catalog_DACPAC=\"{StringHelper.RefactorPathContainSpace(Path.Combine(setting.DatabaseProjectFolder, FileConstants.CatalogDACPAC))}\"");
            strList.Add($"");
            strList.Add($"set Core_DACPAC=\"{StringHelper.RefactorPathContainSpace(Path.Combine(setting.DatabaseProjectFolder, FileConstants.CoreDACPAC))}\"");
            strList.Add($"");
            strList.Add($"set WorkingPaper_DACPAC=\"{StringHelper.RefactorPathContainSpace(Path.Combine(setting.DatabaseProjectFolder, FileConstants.WorkingPaperDACPAC))}\"");
            strList.Add($"");
            strList.Add($"set SqlPackage=\"{setting.SQLPackage}\"");
            strList.Add($"");
            strList.Add($":: Geo information to create login user for Catalog database");
            strList.Add($"");
            strList.Add($"set Geo={server.GEO}");
            strList.Add($"");
            strList.Add($"set Geo_Login_Password={server.GEOPassword}");
            strList.Add($"");
            strList.Add($":: Container code information to create login user for Core & WorkingPaper database");
            strList.Add($"");
            strList.Add($"set UserContainerCode={server.UserContainerCode}");
            strList.Add($"");
            strList.Add($"set Contaner_Login_Password={server.ContainerPassword}");
            strList.Add($"");
            strList.Add($":: Container code to create prefix database");
            strList.Add($"");
            strList.Add($"set ContainerCode={server.ContainerCode}");
            strList.Add($"");
            strList.Add($":: SQL Server information");
            strList.Add($"");
            strList.Add($"set SQLServerInstance={server.Server},{server.Port}");
            strList.Add($"");
            strList.Add($"set SQLServerUsername={server.Login}");
            strList.Add($"");
            strList.Add($"set SQLServerPassword={server.Password}");
            string stringData = string.Join('\n', strList.ToArray());
            return stringData;
        }
    }
}

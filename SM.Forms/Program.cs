using SM.Forms.Forms;
using SM.Models;
using SM.Models.Configuration;
using SM.Models.Storage;
using SM.Shared.Constants;
using SM.Shared.Extensions;
using SM.Shared.Helpers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SM.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadData();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }

        private static void LoadData()
        {
            Global.RootAppFolderPath = Directory.GetCurrentDirectory();
            LoadStartData();
        }

        private static void LoadStartData()
        {
            string _startPath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Start);
            string jsonStartString = FileHelper.ReadFile(_startPath);
            if (jsonStartString.NotNullOrEmpty())
            {
                Global.StartItem = JsonHelper.Deserialize<List<StartItemModel>>(jsonStartString);
            }

            string _settingPath = Path.Combine(Global.RootAppFolderPath, PathConstants.Js_Setting);
            string jsonSettingString = FileHelper.ReadFile(_settingPath);
            if (jsonSettingString.NotNullOrEmpty())
            {
                Global.Configuration = JsonHelper.Deserialize<SettingModel>(jsonSettingString);
            }
        }
    }
}
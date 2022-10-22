using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Constants
{
    public static class PathConstants
    {
        #region [Json Storage]
        public const string Js_Start = FolderConstants.Json.Storage + FileConstants.Start;
        public const string Js_Publish = FolderConstants.Json.Storage + FileConstants.Publish;
        public const string Js_Database = FolderConstants.Json.Storage + FileConstants.Database;
        public const string Js_Replace = FolderConstants.Json.Storage + FileConstants.Replace;
        public const string Js_Feature = FolderConstants.Json.Storage + FileConstants.Feature;
        #endregion

        #region [Json Config]
        public const string Js_Cf = FolderConstants.Json.Configuration + FileConstants.CFServer;
        public const string Js_Main = FolderConstants.Json.Configuration + FileConstants.MainServer;
        public const string Js_Setting = FolderConstants.Json.Configuration + FileConstants.Setting;
        #endregion

        #region [BAT Configuration]
        #region [Path]
        public const string Bat_Path = FolderConstants.Bat.Root + FileConstants.PathConfiguration;
        public const string Bat_Source = FolderConstants.Bat.Root + FileConstants.SourceConfiguration;
        #endregion

        #region [Configuration]
        public const string Bat_Main_Config = FolderConstants.Bat.Database + FileConstants.MainConfiguration;
        public const string Bat_CF_Config = FolderConstants.Bat.Database + FileConstants.CFConfiguration;
        public const string Bat_Main_Server_Config = FolderConstants.Bat.Database + FileConstants.MainServerConfiguration;
        public const string Bat_CF_Server_Config = FolderConstants.Bat.Database + FileConstants.CFServerConfiguration;
        #endregion
        #endregion
    }
}

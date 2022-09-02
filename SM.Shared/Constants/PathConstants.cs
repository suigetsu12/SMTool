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
        #endregion

        #region [Json Config]
        public const string Js_Cf = FolderConstants.Json.Storage + FileConstants.CFServer;
        public const string Js_Main = FolderConstants.Json.Storage + FileConstants.MainServer;
        public const string Js_Setting = FolderConstants.Json.Storage + FileConstants.Setting;
        public const string Js_Sql = FolderConstants.Json.Storage + FileConstants.Sql;
        #endregion
    }
}

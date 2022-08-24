﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Constants
{
    public static class FileConstants
    {
        #region [SQL Folder]
        public const string BackupMain = "script_backup_main" + FileExtensionContants.Sql;
        public const string BackupCF = "script_backup_cf" + FileExtensionContants.Sql;
        public const string RestoreMain = "script_restore_main" + FileExtensionContants.Sql;
        public const string RestoreCF = "script_restore_cf" + FileExtensionContants.Sql;
        public const string Drop = "script_drop" + FileExtensionContants.Sql;
        #endregion

        #region [BAT Folder]
        public const string SourceConfiguraion = "source_config" + FileExtensionContants.Bat;//app_config.bat
        public const string OutputConfiguraion = "output_config" + FileExtensionContants.Bat;//app_config.bat
        public const string PathConfiguraion = "path_config" + FileExtensionContants.Bat;//_path.bat
        #endregion

        #region [JSON Folder]

        #region [Storage]
        public const string Start = "start" + FileExtensionContants.Json;//dataStart.json
        public const string Publish = "publish" + FileExtensionContants.Json;//dataPublish.json
        public const string Database = "database" + FileExtensionContants.Json;//dataDatabase.json
        public const string Replace = "replace" + FileExtensionContants.Json;//store queue value to replace in the appsetting.json file
        #endregion

        #region [Configuration]
        public const string Sql = "sql" + FileExtensionContants.Json;
        public const string MainServer = "main" + FileExtensionContants.Json;
        public const string CFServer = "cf" + FileExtensionContants.Json;
        public const string Setting = "setting" + FileExtensionContants.Json;
        #endregion

        #endregion
    }
}

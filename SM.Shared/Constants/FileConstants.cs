using System;
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
        public const string StartStorage = "start" + FileExtensionContants.Json;//dataStart.json
        public const string PublishStorage = "publish" + FileExtensionContants.Json;//dataPublish.json
        public const string DatabaseStorage = "database" + FileExtensionContants.Json;//dataDatabase.json
        public const string SqlStorage = "sql" + FileExtensionContants.Json;
        public const string MainServerStorage = "main" + FileExtensionContants.Json;
        public const string CFServerStorage = "cf" + FileExtensionContants.Json;
        public const string SettingStorage = "setting" + FileExtensionContants.Json;
        #endregion
    }
}

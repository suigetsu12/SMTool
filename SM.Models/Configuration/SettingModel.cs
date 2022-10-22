using System.Text.Json.Serialization;

namespace SM.Models.Configuration
{
    public class SettingModel
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("publish_folder")]
        public string PublishFolder { get; set; }

        [JsonPropertyName("backup_data_folder")]
        public string BackupDataFolder { get; set; }

        [JsonPropertyName("project_folder")]
        public string ProjectFolder { get; set; }

        [JsonPropertyName("database_project_folder")]
        public string DatabaseProjectFolder { get; set; }

        [JsonPropertyName("VsDevCmd_path")]
        public string VsDevCmdPath { get; set; }

        [JsonPropertyName("MsBuils_path")]
        public string MSBuildPath { get; set; }

        [JsonPropertyName("azureFuncTool_path")]
        public string AzureFuncToolPath { get; set; }

        [JsonPropertyName("sqlcmd")]
        public string SQLCMD { get; set; }

        [JsonPropertyName("sql_package")]
        public string SQLPackage { get; set; }
    }
}

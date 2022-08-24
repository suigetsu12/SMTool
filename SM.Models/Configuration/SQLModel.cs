using System.Text.Json.Serialization;

namespace SM.Models.Configuration
{
    public class SQLModel
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("sqlcmd")]
        public string SQLCMD { get; set; }

        [JsonPropertyName("sql_server_solution")]
        public string SQLServerSolution { get; set; }

        [JsonPropertyName("catalog_dacpac")]
        public string CatalogDACPAC { get; set; }

        [JsonPropertyName("core_dacpac")]
        public string CoreDACPAC { get; set; }

        [JsonPropertyName("workingpaper_dacpac")]
        public string WorkingPaperDACPAC { get; set; }

        [JsonPropertyName("sql_package")]
        public string SQLPackage { get; set; }

        [JsonPropertyName("deployenv")]
        public string DeployEnv { get; set; }

        [JsonPropertyName("msbuild")]
        public string MsBuild { get; set; }
    }
}

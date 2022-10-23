using SM.Shared.Enums;
using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class PublishItemModel : BaseModel
    {
        [JsonPropertyName("publish_type")]
        public PublishType PublishType { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("project_folder"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ProjectFolder { get; set; }

        [JsonPropertyName("project_param"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ProjectParam { get; set; }

        [JsonPropertyName("output_folder"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string OutputFolder { get; set; }

        [JsonPropertyName("output_param"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string OutputParam { get; set; }
    }
}

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
    }
}

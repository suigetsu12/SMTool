using SM.Shared.Enums;
using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class StartItemModel : BaseModel
    {
        [JsonPropertyName("ischecked")]
        public bool IsChecked { get; set; }

        [JsonPropertyName("features")]
        public List<FeatureType> Features { get; set; }

        [JsonIgnore]
        public string Message { get; set; }

        [JsonIgnore]
        public int ProcessId { get; set; }
    }
}

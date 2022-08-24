using SM.Shared.Enums;
using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class ReplaceItemModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("type")]
        public DataType DataType { get; set; }
    }
}

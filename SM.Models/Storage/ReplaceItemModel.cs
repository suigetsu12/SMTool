using SM.Shared.Enums;
using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class ReplaceItemModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("key_name")]
        public string KeyName { get; set; }

        [JsonPropertyName("values")]
        public List<ValueModel> Values { get; set; }

        [JsonPropertyName("type")]
        public bool Type { get; set; }
    }

    public class ValueModel
    {
        [JsonPropertyName("old_value")]
        public string OldValue { get; set; }

        [JsonPropertyName("new_value")]
        public string NewValue { get; set; }

        [JsonPropertyName("default")]
        public bool Default { get; set; }
    }
}

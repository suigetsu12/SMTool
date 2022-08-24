using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class BaseModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}

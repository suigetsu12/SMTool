using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class BaseModel : BaseItemModel
    {
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}

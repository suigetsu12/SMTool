using SM.Shared.Enums;
using System.Text.Json.Serialization;

namespace SM.Models.Storage
{
    public class DatabaseItemModel : BaseModel
    {
        [JsonPropertyName("action_type")]
        public DatabaseActionType ActionType { get; set; }
    }
}

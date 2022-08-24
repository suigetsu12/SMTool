using System.Text.Json.Serialization;

namespace SM.Models.Configuration
{
    public class ServerModel
    {
        [JsonPropertyName("server")]
        public string Server { get; set; }

        [JsonPropertyName("db")]
        public string DB { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("port")]
        public string Port { get; set; }

        [JsonPropertyName("geo")]
        public string GEO { get; set; }

        [JsonPropertyName("geo_password")]
        public string GEOPassword { get; set; }

        [JsonPropertyName("user_container_code")]
        public string UserContainerCode { get; set; }

        [JsonPropertyName("container_password")]
        public string ContainerPassword { get; set; }

        [JsonPropertyName("container_code")]
        public string ContainerCode { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models.WeatherDetails
{
    public class Wind
    {
        [JsonPropertyName("speed")]
        public float Speed { get; set; }
    }
}

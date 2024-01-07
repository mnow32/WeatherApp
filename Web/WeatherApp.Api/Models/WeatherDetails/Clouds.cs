using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models.WeatherDetails
{
    public class Clouds
    {
        [JsonPropertyName("all")]
        public float All { get; set; }
    }
}

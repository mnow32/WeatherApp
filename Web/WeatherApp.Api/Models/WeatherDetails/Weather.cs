using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models.WeatherDetails
{
    public class Weather
    {
        [JsonPropertyName("main")]
        public string? Main { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }        
    }
}

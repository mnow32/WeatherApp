using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models.WeatherDetails
{
    public class Coord
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}

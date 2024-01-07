using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models.WeatherDetails
{
    public class Rain
    {
        [JsonPropertyName("1h")]
        public float OneHourRainVolume { get; set; }

        [JsonPropertyName("3h")]
        public float ThreeHourRainVolume { get; set; }
    }
}

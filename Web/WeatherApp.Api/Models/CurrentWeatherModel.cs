using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using WeatherApp.Api.Models.WeatherDetails;

namespace WeatherApp.Api.Models
{
    public class CurrentWeatherModel
    {
        public Coord? Coord { get; set; }
        public Weather[]? Weather { get; set; }
        public Main? Main { get; set; }
        public int Visibility { get; set; }
        public Wind? Wind { get; set; }
        public Rain? Rain { get; set; }
        public Clouds? Clouds { get; set; }

        [JsonPropertyName("dt")]
        public double UnixCalculationTime { get; set; }
        public Sys? Sys { get; set; }
        
        public DateTime CalculationTime
        {
            get
            {
                DateTime dateTimeValue = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTimeValue = dateTimeValue.AddSeconds(UnixCalculationTime).ToUniversalTime();
                return dateTimeValue;
            }
        }
    }
}

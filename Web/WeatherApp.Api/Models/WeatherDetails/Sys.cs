using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models.WeatherDetails
{
    public class Sys
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("sunrise")]
        public double UnixSunriseTime { get; set; }

        [JsonPropertyName("sunset")]
        public double UnixSunsetTime { get; set; }

        [JsonPropertyName("sunrise_time")]
        public DateTime SunriseTime
        {
            get
            {
                DateTime dateTimeValue = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTimeValue = dateTimeValue.AddSeconds(UnixSunriseTime).ToUniversalTime();
                return dateTimeValue;
            }
        }

        [JsonPropertyName("sunset_time")]
        public DateTime SunsetTime
        {
            get
            {
                DateTime dateTimeValue = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTimeValue = dateTimeValue.AddSeconds(UnixSunsetTime).ToUniversalTime();
                return dateTimeValue;
            }
        }

    }
}

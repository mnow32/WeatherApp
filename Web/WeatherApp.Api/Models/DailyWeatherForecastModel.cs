using System.Text.Json.Serialization;
using WeatherApp.Api.Models.WeatherDetails;

namespace WeatherApp.Api.Models
{
    public class DailyWeatherForecastModel
    {
        [JsonPropertyName("dt")]
        public double UnixDate { get; set; }
        public Main? Main { get; set; }
        public Weather[]? Weather { get; set; }
        public int Visibility { get; set; }
        public Wind? Wind { get; set; }
        public Rain? Rain { get; set; }
        public Clouds? Clouds { get; set; }

        public DateTime ForecastDate
        {
            get
            {
                DateTime dateTimeValue = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTimeValue = dateTimeValue.AddSeconds(UnixDate).ToUniversalTime();
                return dateTimeValue.Date;
            }
        }
    }
}

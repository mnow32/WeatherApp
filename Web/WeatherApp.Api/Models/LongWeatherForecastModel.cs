using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace WeatherApp.Api.Models
{
    public class LongWeatherForecastModel
    {
        [JsonPropertyName("list")]
        public IEnumerable<DailyWeatherForecastModel>? ForecastList { get; set; }
    }
}

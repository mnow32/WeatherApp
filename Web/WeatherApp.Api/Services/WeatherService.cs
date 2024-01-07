using System.Text.Json;
using WeatherApp.Api.Models;

namespace WeatherApp.Api.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IHttpClientFactory _clientFactory;

        public WeatherService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<string> GetWeatherByCityCoordAsync(double lat, double lon)
        {
            var client = _clientFactory.CreateClient();
            //TODO: make it more elegent - sucking from appsettings etc.
            //TODO: add some kind of error handling
            //client.BaseAddress = new Uri("http://api.openweathermap.org/geo/1.0/");
            try
            {
                string address = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=2e38ff55ae99374464124535616ae7ff&units=metric";

                CurrentWeatherModel? weather = await client.GetFromJsonAsync<CurrentWeatherModel>(address);

                return JsonSerializer.Serialize<CurrentWeatherModel>(weather!);
            }
            catch (Exception ex)
            {

            }
            return null!;
        }

        public async Task<string> GetForecastByCityCoordAsync(double lat, double lon)
        {
            var client = _clientFactory.CreateClient();
            //TODO: make it more elegent - sucking from appsettings etc.
            //TODO: add some kind of error handling
            //client.BaseAddress = new Uri("http://api.openweathermap.org/geo/1.0/");
            try
            {
                string address = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid=2e38ff55ae99374464124535616ae7ff&units=metric";

                LongWeatherForecastModel? weatherForecast = await client.GetFromJsonAsync<LongWeatherForecastModel>(address);

                return JsonSerializer.Serialize<LongWeatherForecastModel>(weatherForecast!);
            }
            catch (Exception ex)
            {

            }
            return null!;
        }

    }
}

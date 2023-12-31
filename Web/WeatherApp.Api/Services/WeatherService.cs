using WeatherApp.Api.Models;

namespace WeatherApp.Api.Services
{
    public class WeatherService
    {
        private readonly IHttpClientFactory _clientFactory;

        public WeatherService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<CityModel>> GetWeatherByCityCoord(double lat, double lon)
        {
            List<CityModel>? cities = new();
            var client = _clientFactory.CreateClient();
            //TODO: make it more elegent - sucking from appsettings etc.
            //TODO: add some kind of error handling
            //client.BaseAddress = new Uri("http://api.openweathermap.org/geo/1.0/");
            try
            {
                string address = $"http://api.openweathermap.org/geo/1.0/direct?q={name}&limit=5&appid=2e38ff55ae99374464124535616ae7ff";
                cities = await client.GetFromJsonAsync<List<CityModel>>(address);
            }
            catch (Exception ex)
            {

            }
            return cities;
        }
    }
}

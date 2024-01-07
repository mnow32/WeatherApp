
namespace WeatherApp.Api.Services
{
    public interface IWeatherService
    {
        Task<string> GetForecastByCityCoordAsync(double lat, double lon);
        Task<string> GetWeatherByCityCoordAsync(double lat, double lon);
    }
}
using WeatherApp.Api.Models;

namespace WeatherApp.Api.Services
{
    public interface IGeocodingService
    {
        Task<string> GetCitiesByName(string name);
    }
}
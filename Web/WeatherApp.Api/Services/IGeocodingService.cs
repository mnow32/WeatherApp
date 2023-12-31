using WeatherApp.Api.Models;

namespace WeatherApp.Api.Services
{
    public interface IGeocodingService
    {
        Task<List<CityModel>> GetCitiesByName(string name);
    }
}
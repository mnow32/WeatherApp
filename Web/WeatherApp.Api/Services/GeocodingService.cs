using WeatherApp.Api.Models;
using System.Text.Json;

namespace WeatherApp.Api.Services;

public class GeocodingService : IGeocodingService
{
    private readonly IHttpClientFactory _clientFactory;

    public GeocodingService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<string> GetCitiesByName(string name)
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
        return  JsonSerializer.Serialize<List<CityModel>>(cities);
    }
}

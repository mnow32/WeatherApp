using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Api.Services;

namespace WeatherApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService) 
        {
            _weatherService = weatherService;
        }

        [HttpGet("/currentWeather")]
        public async Task<IActionResult> GetWeatherByCityCoordinates(double lat, double lon)
        {
            var response = await _weatherService.GetWeatherByCityCoordAsync(lat, lon);
            if(response is not null)
            {
                return Ok(response);
            }
            return BadRequest();
        }

        [HttpGet("/weatherForecast")]
        public async Task<IActionResult> GetForecastByCityCoord(double lat, double lon)
        {
            var response = await _weatherService.GetForecastByCityCoordAsync(lat, lon);
            if (response is not null)
            {
                return Ok(response);
            }
            return BadRequest();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Api.Models;
using WeatherApp.Api.Services;

namespace WeatherApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeocodingController : ControllerBase
    {
        private readonly IGeocodingService _geocodingService;

        public GeocodingController(IGeocodingService geocodingService)
        {
            _geocodingService = geocodingService;
        }

        //TODO: Read more about this decorator
        [HttpGet("city")]
        public async Task<IActionResult> GetCitiesByName(string city)
        {
            var response = await _geocodingService.GetCitiesByName(city);
            if (response is not null)
            {
                return Ok(response);
            }
            return BadRequest();
        }
    }
}

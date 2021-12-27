using Microsoft.AspNetCore.Mvc;
using BaseApi.Shared.Entities;
using BaseApi.Business.Interfaces;
namespace BaseApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var weather = await _weatherService.GetWeatherAsync();
            return weather;
        }

        [HttpGet("{id}")]
        public async Task<WeatherForecast> Get(int id)
        {
            var weather = await _weatherService.GetWeatherForecastByIdAsync(id);
            return weather;
        }
    }
}
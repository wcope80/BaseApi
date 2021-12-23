using Microsoft.AspNetCore.Mvc;
using BaseApi.Business.Models;
using BaseApi.Business.Interfaces;
using System.Threading.Tasks;

namespace BaseApi.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            _logger.LogInformation("GetWeatherForecast()");
            var result = await _weatherService.GetWeatherAsync();
            return result;

            
        }
    }
}
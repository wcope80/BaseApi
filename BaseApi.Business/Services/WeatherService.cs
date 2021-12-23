using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApi.Business.Interfaces;
using BaseApi.Business.Models;
using Microsoft.Extensions.Logging;

namespace BaseApi.Business.Services
{
    public class WeatherService : IWeatherService
    {
        public readonly ILogger<WeatherService> _logger;
        public WeatherService(ILogger<WeatherService> logger)
        {
            _logger = logger;
        }
        public async Task<IEnumerable<WeatherForecast>> GetWeatherAsync()
        {
            _logger.LogInformation("WeatherService.GetWeatherAsync");
            string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}

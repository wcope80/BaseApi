using BaseApi.Data.Interfaces;
using BaseApi.Shared.Entities;
using Microsoft.Extensions.Logging;


namespace BaseApi.Data.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly ILogger<WeatherRepository> _logger;

        public WeatherRepository(ILogger<WeatherRepository> logger)
        {
            _logger = logger;
        }

        private List<WeatherForecast> _weatherContext = new List<WeatherForecast>()
        {
            new WeatherForecast() { Id = 1, City = "Atlanta", Date = DateTime.Today, TemperatureC = 20},
            new WeatherForecast() { Id = 2, City = "Chicago", Date = DateTime.Today, TemperatureC = 05},
            new WeatherForecast() { Id = 3, City = "Los Angeles", Date = DateTime.Today, TemperatureC = 30},
            new WeatherForecast() { Id = 4, City = "San Antonio", Date = DateTime.Today, TemperatureC = 28}
        };

        public async Task<List<WeatherForecast>> GetWeatherForecastsAsync()
        {
            _logger.LogInformation("GetWeatherForecastsAsync");
            return await Task.FromResult(_weatherContext);
        }
    }
}

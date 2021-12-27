using BaseApi.Data.Interfaces;
using BaseApi.Shared.Entities;
using BaseApi.Data.DBContexts;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace BaseApi.Data.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly ILogger<WeatherRepository> _logger;
        private readonly BaseApiContext _context;

        public WeatherRepository(ILogger<WeatherRepository> logger, BaseApiContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<List<WeatherForecast>> GetWeatherForecastsAsync()
        {
            _logger.LogInformation("GetWeatherForecastsAsync");
            var weather = await _context.WeatherForecasts.ToListAsync();
            return weather;
        }
    }
}

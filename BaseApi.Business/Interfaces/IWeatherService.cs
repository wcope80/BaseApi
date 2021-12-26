using BaseApi.Shared.Entities;

namespace BaseApi.Business.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherAsync();
    }
}

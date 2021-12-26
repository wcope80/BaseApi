using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApi.Shared.Entities;

namespace BaseApi.Data.Interfaces
{
    public interface IWeatherRepository
    {
        Task<List<WeatherForecast>> GetWeatherForecastsAsync();
    }
}

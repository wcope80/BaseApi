using Microsoft.EntityFrameworkCore;
using BaseApi.Shared.Entities;

namespace BaseApi.Data.Interfaces;

public interface IBaseApiContext
{
    DbSet<WeatherForecast> WeatherForecasts { get; set; }
}


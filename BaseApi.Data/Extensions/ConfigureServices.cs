using Microsoft.Extensions.DependencyInjection;
using BaseApi.Data.Interfaces;
using BaseApi.Data.Repositories;
using BaseApi.Data.DBContexts;

namespace BaseApi.Data.Extensions;

public static class ConfigureServices
{
    public static void AddData(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IWeatherRepository, WeatherRepository>();
        serviceCollection.AddDbContext<BaseApiContext>();
    }
}


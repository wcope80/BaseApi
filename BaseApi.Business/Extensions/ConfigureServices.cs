using Microsoft.Extensions.DependencyInjection;
using BaseApi.Business.Interfaces;
using BaseApi.Business.Services;

namespace BaseApi.Business.Extensions
{
    public static class ConfigureServices
    {
        public static void AddBusiness(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IWeatherService, WeatherService>();
        }
    }
}

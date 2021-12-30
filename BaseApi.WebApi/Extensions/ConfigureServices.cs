using Microsoft.Extensions.DependencyInjection;
using BaseApi.WebApi.Services.Authentication.Interfaces;
using BaseApi.WebApi.Services.Authentication;

namespace BaseApi.WebApi.Extensions
{
    public static class ConfigureServices
    {
        public static void AddWebApi(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IUserContext, UserContext>();
        }
    }
}

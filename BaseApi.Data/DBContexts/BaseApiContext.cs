using Microsoft.EntityFrameworkCore;
using BaseApi.Shared.Entities;
using Microsoft.Extensions.Options;

namespace BaseApi.Data.DBContexts
{
    public class BaseApiContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public ConnectionString _connectionString { get; }

        public BaseApiContext(IOptions<ConnectionString> connectionString)
        {
            _connectionString = connectionString.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(_connectionString.DbPath);


    }

}

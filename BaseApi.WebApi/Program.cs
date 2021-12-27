using Serilog;
using BaseApi.Business.Interfaces;
using BaseApi.Business.Services;
using BaseApi.WebApi.Models;
using BaseApi.WebApi.Services;
using BaseApi.WebApi.Helpers;
using BaseApi.Data.Interfaces;
using BaseApi.Data.Repositories;
using BaseApi.Data.DBContexts;
using BaseApi.Shared.Entities;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Starting up");

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JWTKey>(builder.Configuration.GetSection("JWTKey"));
builder.Services.Configure<ApiUsers>(builder.Configuration.GetSection("ApiUsers"));
builder.Services.Configure<ConnectionString>(builder.Configuration.GetSection("ConnectionString"));

//Serilog 
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));

// Add services to the container.
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<IUserService, UserService>();

//Repositories
builder.Services.AddScoped<IWeatherRepository, WeatherRepository>();

//Contexts
builder.Services.AddScoped(typeof(BaseApiContext));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSerilogRequestLogging();

app.UseMiddleware<JwtMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

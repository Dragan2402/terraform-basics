using Microsoft.EntityFrameworkCore;
using weather_api.Extensions;
using weather_api.Infrastructure;
using weather_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "_AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<WeatherDbContext>(
options => options
    .UseNpgsql(
            builder.Configuration.GetConnectionString("DefaultConnection")
        ),
    ServiceLifetime.Scoped
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITemperatureService, TemperatureService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<WeatherDbContext>();
    context.Database.Migrate();
}

app.UseCors("_AllowAllOrigins");

app.RegisterMinimalEndpoints();

app.Run();

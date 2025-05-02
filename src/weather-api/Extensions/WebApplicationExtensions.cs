using Microsoft.AspNetCore.Mvc;
using weather_api.Model;
using weather_api.Services;

namespace weather_api.Extensions
{
    public static class WebApplicationExtensions
    {
        public static void RegisterMinimalEndpoints(this WebApplication app)
        {
            app.MapGet("/temperatures", async (ITemperatureService temperatureService) =>
            {
                var forecasts = await temperatureService.GetTemperaturesAsync();
                return Results.Ok(forecasts);
            })
            .WithName("GetTemperatures")
            .Produces<IEnumerable<Temperature>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status500InternalServerError);

            app.MapGet("/temperatures/{id:int}", async (int id, ITemperatureService temperatureService) =>
            {
                try
                {

                    var forecast = await temperatureService.GetTemperatureByIdAsync(id);
                    return Results.Ok(forecast);
                }
                catch (Exception ex)
                {
                    return Results.NotFound(ex.Message);
                }
            })
            .WithName("GetTemperatureById")
            .Produces<Temperature>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            app.MapPost("/temperatures", async ([FromBody] double value, ITemperatureService temperatureService) =>
            {
                var temperature = await temperatureService.AddTemperatureAsync(value);
                return Results.Created($"/temperatures/{temperature.Id}", temperature);
            })
            .WithName("AddTemperature")
            .Produces<Temperature>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            app.MapDelete("/temperatures/{id:int}", async (int id, ITemperatureService temperatureService) =>
            {
                await temperatureService.DeleteTemperatureAsync(id);
                return Results.NoContent();
            })
            .WithName("DeleteTemperature")
            .Produces(StatusCodes.Status204NoContent);
        }
    }
}

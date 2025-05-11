using weather_api.Model;

namespace weather_api.Services
{
    public class TemperatureService : ITemperatureService
    {
        private readonly IDbSimulationService simulationServer;

        public TemperatureService(IDbSimulationService context)
        {
            simulationServer = context;
        }

        public async Task<Temperature> AddTemperatureAsync(double value)
        {
            return await simulationServer.AddTemperatureAsync(new Temperature
            {
                Time = DateTime.UtcNow,
                Value = value
            });
        }

        public async Task DeleteTemperatureAsync(int id)
        {
            await simulationServer.DeleteTemperatureAsync(id);
        }

        public async Task<Temperature> GetTemperatureByIdAsync(int id)
        {
            return await simulationServer.GetTemperatureByIdAsync(id);
        }

        public Task<IEnumerable<Temperature>> GetTemperaturesAsync()
        {
            return simulationServer.GetTemperaturesAsync();
        }

        //public async Task<Temperature> AddTemperatureAsync(double value)
        //{
        //    var temperature = new Temperature
        //    {
        //        Time = DateTime.UtcNow,
        //        Value = value
        //    };

        //    var addedTemperature = simulationServer.Temperatures.Add(temperature);
        //    await simulationServer.SaveChangesAsync();
        //    return addedTemperature.Entity;
        //}

        //public async Task DeleteTemperatureAsync(int id)
        //{
        //    var temperature = simulationServer.Temperatures.Find(id);

        //    if (temperature != null)
        //    {
        //        simulationServer.Temperatures.Remove(temperature);
        //        await simulationServer.SaveChangesAsync();
        //    }
        //}

        //public async Task<Temperature> GetTemperatureByIdAsync(int id)
        //{
        //    return await simulationServer.Temperatures.FindAsync(id) ?? throw new Exception("Temperature not found");
        //}

        //public async Task<IEnumerable<Temperature>> GetTemperaturesAsync()
        //{
        //    return await simulationServer.Temperatures.ToListAsync();
        //}
    }
}

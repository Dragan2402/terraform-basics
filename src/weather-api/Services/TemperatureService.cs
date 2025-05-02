using Microsoft.EntityFrameworkCore;
using weather_api.Infrastructure;
using weather_api.Model;

namespace weather_api.Services
{
    public class TemperatureService : ITemperatureService
    {
        private readonly WeatherDbContext _context;

        public TemperatureService(WeatherDbContext context)
        {
            _context = context;
        }

        public async Task<Temperature> AddTemperatureAsync(double value)
        {
            var temperature = new Temperature
            {
                Time = DateTime.UtcNow,
                Value = value
            };

            var addedTemperature = _context.Temperatures.Add(temperature);
            await _context.SaveChangesAsync();
            return addedTemperature.Entity;
        }

        public async Task DeleteTemperatureAsync(int id)
        {
            var temperature = _context.Temperatures.Find(id);

            if (temperature != null)
            {
                _context.Temperatures.Remove(temperature);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Temperature> GetTemperatureByIdAsync(int id)
        {
            return await _context.Temperatures.FindAsync(id) ?? throw new Exception("Temperature not found");
        }

        public async Task<IEnumerable<Temperature>> GetTemperaturesAsync()
        {
            return await _context.Temperatures.ToListAsync();
        }
    }
}

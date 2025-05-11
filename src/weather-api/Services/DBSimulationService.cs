using weather_api.Model;

namespace weather_api.Services
{
    public class DBSimulationService : IDbSimulationService
    {
        private readonly IDictionary<int, Temperature> _temperatures = new Dictionary<int, Temperature>();
        private int _nextId = 1;

        public Task<Temperature> AddTemperatureAsync(Temperature temperature)
        {
            if (_temperatures.Count >= 100)
            {
                _temperatures.Clear();
                _nextId = 1;
            }

            temperature.Id = _nextId++;
            _temperatures.Add(temperature.Id, temperature);
            return Task.FromResult(temperature);
        }

        public Task<Temperature> GetTemperatureByIdAsync(int id)
        {
            if (_temperatures.TryGetValue(id, out var temperature))
            {
                return Task.FromResult(temperature);
            }
            throw new Exception("Temperature not found");
        }

        public Task DeleteTemperatureAsync(int id)
        {
            if (_temperatures.ContainsKey(id))
            {
                _temperatures.Remove(id);
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Temperature>> GetTemperaturesAsync()
        {
            return Task.FromResult<IEnumerable<Temperature>>(_temperatures.Values);
        }
    }
}

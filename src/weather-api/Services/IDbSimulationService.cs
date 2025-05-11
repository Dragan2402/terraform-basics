using weather_api.Model;

namespace weather_api.Services
{
    public interface IDbSimulationService
    {
        Task<Temperature> AddTemperatureAsync(Temperature temperature);
        Task<Temperature> GetTemperatureByIdAsync(int id);
        Task<IEnumerable<Temperature>> GetTemperaturesAsync();
        Task DeleteTemperatureAsync(int id);
    }
}

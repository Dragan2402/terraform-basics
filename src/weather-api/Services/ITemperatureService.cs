using weather_api.Model;

namespace weather_api.Services
{
    public interface ITemperatureService
    {
        Task<IEnumerable<Temperature>> GetTemperaturesAsync();
        Task<Temperature> GetTemperatureByIdAsync(int id);
        Task<Temperature> AddTemperatureAsync(double value);
        Task DeleteTemperatureAsync(int id);
    }
}

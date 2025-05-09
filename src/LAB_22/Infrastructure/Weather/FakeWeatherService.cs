using LAB_22.Core;

namespace LAB_22.Infrastructure.Weather
{
    public class FakeWeatherService : IWeatherService
    {
        public Task<double> GetTemperature(string region) => Task.FromResult(36.6);
    }
}

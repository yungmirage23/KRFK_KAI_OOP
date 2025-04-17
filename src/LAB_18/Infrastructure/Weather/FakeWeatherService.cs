namespace LAB_18
{
    public class FakeWeatherService : IWeatherService
    {
        public Task<double> GetTemperature(string region) => Task.FromResult(36.6);
    }
}

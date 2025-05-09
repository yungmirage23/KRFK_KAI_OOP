namespace LAB_22.Core
{
    public interface IWeatherService
    {
        public Task<double> GetTemperature(string region);
    }
}

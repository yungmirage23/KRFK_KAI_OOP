namespace LAB_18
{
    public interface IWeatherService
    {
        public Task<double> GetTemperature(string region);
    }
}

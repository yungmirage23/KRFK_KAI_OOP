namespace LAB_23_24_25.Adapter
{

    public interface ITemperatureSensor
    {
        double GetTemperatureC();
    }

    public class TemperatureAdapter : ITemperatureSensor
    {
        private readonly FahrenheitSernsor _fahrenheitSernsor;

        public TemperatureAdapter(FahrenheitSernsor fahrenheitSernsor)
        {
            _fahrenheitSernsor = fahrenheitSernsor;
        }
        public double GetTemperatureC()
        {
            var fahrenheit = _fahrenheitSernsor.GetTemperatureInFahrenheit();
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    public class FahrenheitSernsor
    {
        public double GetTemperatureInFahrenheit()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }
    }
}

using System.Text.Json;

namespace LAB_18.Core.Weather
{
    public class WeatherService : IWeatherService
    {
        private readonly Dictionary<string, (double lat, double lon)> _regions = new()
        {
            ["kyiv"] = (50.45, 30.52),
            ["lviv"] = (49.84, 24.03),
            ["odesa"] = (46.48, 30.73),
            ["kharkiv"] = (49.99, 36.23)
        };

        public async Task<double> GetTemperature(string region)
        {
            if (!_regions.TryGetValue(region.ToLower(), out var coords))
                throw new ArgumentException("Unknown region");

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={coords.lat}&longitude={coords.lon}&current_weather=true";

            using var client = new HttpClient();

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);

            double temp = 0;
            foreach (var item in doc.RootElement.EnumerateArray())
            {
                temp = item.GetProperty("current_weather").GetProperty("temperature").GetDouble();
                Console.WriteLine($"Температура: {temp} °C");

            }
            return temp;
        }
    }
}

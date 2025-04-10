namespace LAB_14
{
    public class Test
    {

        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token;

        public Test()
        {
            token = cts.Token;
        }

        public void TestMethod()
        {
        }
        

        public async Task LoadDataAsync(string sourceName)
        {
            var rnd = new Random();
            int delay = rnd.Next(1000, 4000); // Випадкова затримка 1-4 сек
            Console.WriteLine($"{sourceName}: завантаження ({delay} мс)...");

            await Task.Delay(delay);
        }


        public async Task<HttpResponseMessage> GetHtmlAsync(string url)
        {
            var rnd = new Random();
            int delay = rnd.Next(1000, 4000); // Випадкова затримка 1-4 сек
            Console.WriteLine($"{url}: завантаження ({delay} мс)...");

            using HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);

            await Task.Delay(delay);

            Console.WriteLine($"{url}: done.");

            return response;
        }


    }
}
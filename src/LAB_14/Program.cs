namespace LAB_14
{
    internal partial class Program
    {
        private static CancellationTokenSource cts = new CancellationTokenSource();
        private static CancellationToken token = cts.Token;

        private static async Task Main(string[] args)
        {
            var mas = new List<int> { 1, 4, 8, 9, 2, 5, 1, 7, 4 };

            await Task.WhenAll(LogMas(mas), AddMas(mas, 10));

            Console.WriteLine("A");
            Console.ReadLine();
        }

        private static SemaphoreSlim semaphore = new SemaphoreSlim(1,1);
        private static object obj = new();

        private static async Task AddMas(List<int> mas, int value)
        {

            await Task.Delay(5000);

            Console.WriteLine("Starting insert");

            semaphore.Wait();

            mas.Add(value);

            semaphore.Release();

            Console.WriteLine("Inserted");
        }

        private static async Task LogMas(List<int> mas)
        {
            Console.WriteLine("Starting loop");

            semaphore.Wait();

            foreach (var i in mas)
            {
                Console.WriteLine(i);
                await Task.Delay(1000);
            }

            semaphore.Release();

            Console.WriteLine("Finished loop");
        }
    }
}
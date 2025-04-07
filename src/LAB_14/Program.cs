using Timer = System.Timers.Timer;

namespace LAB_14
{
    internal class Program
    {

        private static CancellationTokenSource cts = new CancellationTokenSource();
        private static CancellationToken token = cts.Token;
        static void Main(string[] args)
        {

            var timer = new Timer();
            timer.Interval = 10000;

            timer.Elapsed += Timer_Elapsed;
            timer.Elapsed += (s, e) =>
            {
                Console.WriteLine("Timer 2 handler");
            };

            timer.AutoReset = false;
            timer.Start();

            var thread = new Thread(PrintThread);

            thread.Start();

            var key = Console.ReadKey();
            
            
            if(key.KeyChar == 'e')
            {
                cts.Cancel();
            }


            thread.Join();
        }

        private static void PrintThread()
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }


                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} end");
        }

        private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            cts.Cancel();
        }
    }
}

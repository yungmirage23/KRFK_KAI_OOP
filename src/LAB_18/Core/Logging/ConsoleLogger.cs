namespace LAB_18.Core.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            var logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            Console.WriteLine(logMessage);
        }

        public void Log(int message)
        {
            var logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            Console.WriteLine(logMessage);
        }
    }
}

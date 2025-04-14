namespace LAB_14
{
    public interface ILogger
    {
        void Log(string message);
        void Log(int message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FileLogger] {message}");
            // Тут могла б бути логіка запису в файл
        }

        public void Log(int message)
        {
            Console.WriteLine($"[FileLogger] {message}");
            // Тут могла б бути логіка запису в файл   throw new NotImplementedException();
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[ConsoleLogger] {message}");
        }

        public void Log(int message)
        {
            Console.WriteLine($"[ConsoleLogger] {message}");
        }
    }
}

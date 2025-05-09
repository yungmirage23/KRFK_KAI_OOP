namespace LAB_18.Core.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath = "log.txt";

        public void Log(string message)
        {
            var logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(_filePath, logMessage + Environment.NewLine);
        }
    }
}

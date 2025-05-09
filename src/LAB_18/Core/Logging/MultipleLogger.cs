namespace LAB_18.Core.Logging
{
    public class MultipleLogger : ILogger
    {
        private readonly ConsoleLogger consoleLogger;
        private readonly FileLogger fileLogger;

        public MultipleLogger(ConsoleLogger consoleLogger, FileLogger fileLogger)
        {
            this.consoleLogger = consoleLogger;
            this.fileLogger = fileLogger;
        }
        public void Log(string message)
        {
            consoleLogger.Log(message);
            fileLogger.Log(message);
        }
    }
}

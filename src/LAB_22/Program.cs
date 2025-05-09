using LAB_22.Core;
using LAB_22.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LAB_22
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var hostBuilder = Host.CreateApplicationBuilder(args);

            hostBuilder.Configuration
                .AddJsonFile("appsettings.json", optional: false, true)
                .AddEnvironmentVariables();

            hostBuilder.Logging.ClearProviders();
            hostBuilder.Logging.AddJsonConsole();

            hostBuilder.Services.AddSingleton<BankTransactionService>();
            hostBuilder.Services.AddSingleton<IBankAccountRepository, InMemoryBankAccountRepository>();


            var host = hostBuilder.Build();

            var transactionService = host.Services.GetRequiredService<BankTransactionService>();

            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("Hello, world!");
            logger.LogWarning("Hello, world!");
            logger.LogError("Hello, world!");
            logger.LogCritical("Hello, world!");
            logger.LogDebug("Hello, world!");

            var configuration = host.Services.GetRequiredService<IConfiguration>();
            var value = configuration["AccountPassword"];
            Console.WriteLine(value);

            await host.RunAsync();
        }
    }
}
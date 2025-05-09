using LAB_18.Core;
using LAB_18.Core.Logging;
using LAB_18.Infrastructure.Data;

namespace LAB_18
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           
            var cat = new Cat();
            var dog = new Dog();
            cat.Speek();
            cat.Walk();
            dog.Speek();
            dog.Walk();
            ILogger logger = new MultipleLogger(new ConsoleLogger(), new FileLogger());
            IBankAccountRepository bankAccountRepository = new InMemoryBankAccountRepository();


            var registrationService = new BankRegistrationService(logger, bankAccountRepository);
            var transactionService = new BankTransactionService(logger, bankAccountRepository);

            await registrationService.Register("John", "Doe", 1000);
            await registrationService.Register("Jane", "Smith", 2000);

            await transactionService.DepositTransation(0, 1, 500);

        }
    }
}

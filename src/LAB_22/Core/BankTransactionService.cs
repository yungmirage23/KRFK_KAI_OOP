using LAB_22.Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace LAB_22.Core
{
    public class BankTransactionService
    {
        private readonly ILogger logger;
        private readonly IBankAccountRepository bankAccountRepository;

        public BankTransactionService(
            ILogger<BankTransactionService> logger,
            IBankAccountRepository bankAccountRepository)
        {
            this.logger = logger;
            this.bankAccountRepository = bankAccountRepository;
        }

        public async Task DepositTransation(int fromAccountId, decimal amount)
        {
            logger.LogInformation($"Deposit transaction id{fromAccountId} for {amount}");

            var fromAccount = await bankAccountRepository.GetById(fromAccountId);

            fromAccount.Balance += amount;

            logger.LogInformation($"Deposited {amount}UAH from {fromAccount.Id}");
        }

        public async Task DepositTransation(int fromAccountId, int toAccountId, decimal amount)
        {
            logger.LogInformation($"Deposit transaction from id{fromAccountId} to id{toAccountId} for {amount}");

            var fromAccount = await bankAccountRepository.GetById(fromAccountId);
            var toAccount = await bankAccountRepository.GetById(toAccountId);

            if (fromAccount.Balance < amount)
                throw new InvalidOperationException("Not enough money on the account");

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            logger.LogInformation($"Deposited {amount}UAH from id{fromAccount.Id} to id{toAccount.Id} ");
        }

    }
}

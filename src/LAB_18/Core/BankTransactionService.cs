﻿using LAB_18.Core.Logging;
using LAB_18.Infrastructure.Data;

namespace LAB_18.Core
{
    public class BankTransactionService
    {
        private readonly ILogger logger;
        private readonly IBankAccountRepository bankAccountRepository;

        public BankTransactionService(
            ILogger logger,
            IBankAccountRepository bankAccountRepository)
        {
            this.logger = logger;
            this.bankAccountRepository = bankAccountRepository;
        }

        public async Task DepositTransation(int fromAccountId, decimal amount)
        {
            logger.Log($"Deposit transaction id{fromAccountId} for {amount}");

            var fromAccount = await bankAccountRepository.GetById(fromAccountId);

            fromAccount.Balance += amount;

            logger.Log($"Deposited {amount}UAH from {fromAccount.Id}");
        }

        public async Task DepositTransation(int fromAccountId, int toAccountId, decimal amount)
        {
            logger.Log($"Deposit transaction from id{fromAccountId} to id{toAccountId} for {amount}");

            var fromAccount = await bankAccountRepository.GetById(fromAccountId);
            var toAccount = await bankAccountRepository.GetById(toAccountId);

            if(fromAccount.Balance < amount)
                throw new InvalidOperationException("Not enough money on the account");

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            logger.Log($"Deposited {amount}UAH from id{fromAccount.Id} to id{toAccount.Id} ");
        }

    }
}

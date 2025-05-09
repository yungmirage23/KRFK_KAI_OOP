using LAB_22.Core;

namespace LAB_22.Infrastructure.Data
{
    public class InMemoryBankAccountRepository : IBankAccountRepository
    {
        public IReadOnlyCollection<BankAccount> BankAccounts => bankAccounts.AsReadOnly();
        private List<BankAccount> bankAccounts = new();

        public InMemoryBankAccountRepository()
        {
        }


        public Task Add(BankAccount account)
        {
            var existAccount = bankAccounts.FirstOrDefault(x => x.Id == account.Id);
            if (existAccount != null)
            {
                throw new InvalidOperationException($"Account with id{account.Id} already exist");
            }

            bankAccounts.Add(account);

            return Task.CompletedTask;
        }

        public Task RemoveById(int accountId)
        {
            var existAccount = bankAccounts.FirstOrDefault(x => x.Id == accountId);
            if (existAccount == null)
            {
                throw new InvalidOperationException($"Account with id{accountId} not found");
            }

            bankAccounts.Remove(existAccount);

            return Task.CompletedTask;
        }

        public Task<BankAccount> GetById(int accountId)
        {
            var existAccount = bankAccounts.FirstOrDefault(x => x.Id == accountId);

            if (existAccount == null)
            {
                throw new InvalidOperationException($"Account with id{accountId} not found");
            }
            return Task.FromResult(existAccount);
        }

    }
}

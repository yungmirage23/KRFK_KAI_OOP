namespace LAB_17
{
    public class BankAccountRepository
    {
        public IReadOnlyCollection<BankAccount> BankAccounts => bankAccounts.AsReadOnly();
        private List<BankAccount> bankAccounts = new();

        public BankAccountRepository()
        {
        }

       
        public void Add(BankAccount account)
        {
            var existAccount = bankAccounts.FirstOrDefault(x => x.Id == account.Id);
            if (existAccount != null)
            {
                throw new InvalidOperationException($"Account with id{account.Id} already exist");
            }

            bankAccounts.Add(account);
        }

        public void RemoveById(int accountId)
        {
            var existAccount = bankAccounts.FirstOrDefault(x=>x.Id == accountId);
            if (existAccount == null)
            {
                throw new InvalidOperationException($"Account with id{accountId} not found");
            }


            bankAccounts.Remove(existAccount);
        }

        public BankAccount GetById(int accountId)
        {
            var existAccount = bankAccounts.First(x => x.Id == accountId);

            if (existAccount == null)
            {
                throw new InvalidOperationException($"Account with id{accountId} not found");
            }
            return existAccount;
        }

    }
}

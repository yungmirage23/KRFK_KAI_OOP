namespace LAB_17
{
    public class BankAccountRepository
    {
        private List<BankAccount> bankAccounts = new();

        public void Add(BankAccount bankAccount)
        {
            var accountWithSameId = bankAccounts.FirstOrDefault(x => x.Id == bankAccount.Id);
            if(accountWithSameId != null)
            {
                throw new ArgumentException($"Account with id{bankAccount.Id} already exists");
            }

            bankAccounts.Add(bankAccount);

            Console.WriteLine($"Bank account with id{bankAccount.Id} was added");
        }

        public BankAccount GetById(int bankAccountId)
        {
            var account = bankAccounts.FirstOrDefault(x=> x.Id == bankAccountId);
            if (account == null)
            {
                throw new ArgumentNullException($"Account with id{bankAccountId} not found");
            }

            return account;
        }
        public void RemoveById(int bankAccountId)
        {
            Console.WriteLine($"Removing bank account with id{bankAccountId}...");

            var accountIndex = bankAccounts.FindIndex(x => x.Id == bankAccountId);

            if (bankAccountId == -1)
            {
                throw new ArgumentNullException($"Account with id{bankAccountId} not found");
            }

            bankAccounts.RemoveAt(accountIndex);

            Console.WriteLine($"Bank account with id{bankAccountId} was removed");
        }

    }
}

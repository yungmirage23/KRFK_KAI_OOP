namespace LAB_22.Core
{
    public interface IBankAccountRepository
    {
        public Task Add(BankAccount account);

        public Task RemoveById(int accountId);

        public Task<BankAccount> GetById(int accountId);
    }
}

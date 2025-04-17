using LAB_18.Core;

namespace LAB_18.Infrastructure.Data
{
    public class SqlBankAccountRepository : IBankAccountRepository
    {
        public Task Add(BankAccount account)
        {
            throw new NotImplementedException();
        }

        public Task<BankAccount> GetById(int accountId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveById(int accountId)
        {
            throw new NotImplementedException();
        }
    }
}

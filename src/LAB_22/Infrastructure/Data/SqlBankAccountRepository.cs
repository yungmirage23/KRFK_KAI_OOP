using LAB_22.Core;

namespace LAB_22.Infrastructure.Data
{
    public class SqlBankAccountRepository : IBankAccountRepository
    {
        public SqlBankAccountRepository(string connectionString)
        {
            
        }
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

using LAB_18.Core.Logging;

namespace LAB_18.Core
{
    public class BankRegistrationService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly ILogger _logger;
        public BankRegistrationService(IBankAccountRepository bankAccountRepository, ILogger logger)
        {
            _bankAccountRepository = bankAccountRepository;
            _logger = logger;
        }

        private int _idCounter = 0;
        public async Task Register(string firstName, string secondName, decimal balance)
        {
            var account = new BankAccount(_idCounter++, firstName, secondName, balance);
            await _bankAccountRepository.Add(account);
            _logger.Log($"Registered account {account.Id} for {firstName} {secondName}");
        }
    }
}

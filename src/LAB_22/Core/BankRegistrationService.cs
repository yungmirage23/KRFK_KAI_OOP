using Microsoft.Extensions.Logging;

namespace LAB_22.Core
{
    public class BankRegistrationService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly ILogger<BankRegistrationService> _logger;
        public BankRegistrationService(ILogger<BankRegistrationService> logger, IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
            _logger = logger;
        }

        private int _idCounter = 0;
        public async Task Register(string firstName, string secondName, decimal balance)
        {
            var account = new BankAccount(_idCounter++, firstName, secondName, balance);
            await _bankAccountRepository.Add(account);
            _logger.LogInformation($"Registered account id{account.Id} for {firstName} {secondName}");
        }
    }
}

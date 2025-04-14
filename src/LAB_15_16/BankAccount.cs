namespace LAB_14
{
    public class BankAccount
    {
        public int Id { get; set; } = 1;

        public int Balance => balance;

        private int balance;
        private bool isBlocked = false;
        
        public BankAccount()
        {
        }
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1);

        private readonly object _locker = new object();

        public int GetBalance()
        {
            return balance;
        }

        public async Task DepositAsync(int depositAmount)
        {
            if (isBlocked) 
            {
                throw new InvalidOperationException("Account is blocked.");
            }

            await Task.Delay(200);

            //semaphoreSlim.Wait();

            Interlocked.Add(ref balance, depositAmount);
            //Console.WriteLine($"Id:{Id}. Deposited: {depositAmount}. Balance: {Balance}");
            //semaphoreSlim.Release();
        }
        public async Task WithdrawalAsync(int withdrawalAmount)
        {
            var withdrowal = -withdrawalAmount;

            await Task.Delay(300);

            //semaphoreSlim.Wait();

            Interlocked.Add(ref balance, withdrowal);

            //semaphoreSlim.Release();

        }
    }
}

namespace LAB_23_24_25.Strategy
{
    public class CryptoPayment: IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Оплата криптовалютою на суму {amount} грн.");
    }
}

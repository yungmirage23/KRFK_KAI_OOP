namespace LAB_23_24_25.Strategy
{
    public class CardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)=> Console.WriteLine($"Оплата карткою на суму {amount} грн.");
    }
}

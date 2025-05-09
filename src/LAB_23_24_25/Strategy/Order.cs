namespace LAB_23_24_25.Strategy
{
    public class Order
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentMethod(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }


        public void Checkout(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Метод оплати не вибрано.");
                return;
            }
            _paymentStrategy.Pay(amount);
        }
    }

}

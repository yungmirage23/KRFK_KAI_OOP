namespace LAB_23_24_25.Decorator
{
    public class MilkDecorator : IBeverage
    {
        private readonly IBeverage _beverage;
        public MilkDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double GetCost() => _beverage.GetCost() + 5.0;

        public string GetDescription() => _beverage.GetDescription() + " з молоком";
    }
}

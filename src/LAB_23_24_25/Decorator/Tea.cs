namespace LAB_23_24_25.Decorator
{
    public class Tea : IBeverage
    {
        public double GetCost() => 15.0;
        public string GetDescription() => "Чай";
    }
}

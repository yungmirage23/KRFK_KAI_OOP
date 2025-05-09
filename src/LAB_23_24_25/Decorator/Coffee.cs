namespace LAB_23_24_25.Decorator
{
    public class Coffee : IBeverage
    {
        public double GetCost() => 20.0;

        public string GetDescription() => "Кава";
    }
}

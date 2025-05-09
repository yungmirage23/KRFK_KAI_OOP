namespace LAB_23_24_25.Facade
{
    public class CoffeeMachine
    {
        public void TurnOn() => Console.WriteLine("Кавоварка увімкнена.");
        public void MakeCoffee() => Console.WriteLine("Кава готується...");
        public void TurnOff() => Console.WriteLine("Кавоварка вимкнена.");
    }
}

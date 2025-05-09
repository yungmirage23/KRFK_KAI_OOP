using LAB_23_24_25.Adapter;
using LAB_23_24_25.Decorator;
using LAB_23_24_25.Facade;
using LAB_23_24_25.Observer;

namespace LAB_23_24_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            var coffee = new Coffee();
            var coffeeWithMilk = new MilkDecorator(coffee);
            var teaWithMilk = new MilkDecorator(tea);

            Console.WriteLine($"Напій : {tea.GetDescription()} / Ціна: {tea.GetCost()}");
            Console.WriteLine($"Напій : {coffee.GetDescription()} / Ціна: {coffee.GetCost()}");
            Console.WriteLine($"Напій : {coffeeWithMilk.GetDescription()} / Ціна: {coffeeWithMilk.GetCost()}");
            Console.WriteLine($"Напій : {teaWithMilk.GetDescription()} / Ціна: {teaWithMilk.GetCost()}");
        

            


            FahrenheitSernsor sensor= new FahrenheitSernsor();
            
            var coffeFacade = new CoffeeFacade();
            coffeFacade.MakeCoffee();
        }
    }
}

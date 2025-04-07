using System.Linq;

namespace LAB_13
{
    internal partial class Program
    {
        private static Action<int> action;
        private static Func<int, bool> function;
        private static Predicate<int> predicate;
        public enum Fruit : byte
        {
            Apple = 0,
            Orange,
            Pie = 255,
        }

        private static void Main(string[] args)
        {
            var test = new Test();

            test.OnKeyClicked += Test_OnKeyClicked1;

            test.ReadKeys();

        }

        private static void Test_OnKeyClicked1(object? sender, ConsoleKeyInfo e)
        {
            Console.WriteLine($"Key {e.Key}, {e.KeyChar}, {e.Modifiers} was pressed!");
        }

        private static void Order_OnOrderStatusChanged(object? sender, OrderStatus e)
        {
            var order = sender as Order;
            Console.WriteLine($"Order {order.Id} status changed to {e}");
        }

        private static void Test_OnEventHappened(object? sender, int e)
        {
            Console.WriteLine(e);
        }

        private static bool IsGreaterThen5(int x)
        {
            return x > 5;
        }

        private static int Pow(int x, Action<int>? logMessage = null)
        {
            var result = x * x;
            if (logMessage != null)
            {
                logMessage(result);
            }

            return result;
           
        }

        private static void LogToFile(int x, string fruit)
        {
           ///
           ///
           ///
        }
        private static void Log(int x)
        {
            Console.WriteLine(x);
        }

        private static int Func1(int x)
        {
            Console.WriteLine("");

            return x * x;
        }
        private static int Func2(int x)
        {
            return x;
        }



        //private static void Order_OnOrderStatusChanged(object? sender, OrderStatus e)
        //{
        //    var order = sender as Order;
        //    Console.WriteLine($"Order {order.Id} new status: {e.ToString()}");
        //}

        private static void Test_OnKeyClicked(object? sender, EventArgs args)
        {
            Console.WriteLine($"Key was clicked".ToUpper());
        }

        private static bool Action(int x)
        {
            Console.WriteLine("23");
            return true;
        }

        private static void Func(int x)
        {
            Console.WriteLine(x);
        }

       
    }
}
namespace LAB_5
{
    internal partial class Program
    {
        public class Person
        {
            public string Name; 
        }

        static void Main(string[] args)
        {

            var isPositive = IfIsPositiveCalculateFactorial(-5, out var a);


            Console.WriteLine("Hello, World!");
            Console.WriteLine(23.ToString());
        }



        static Person OurPerson = null;
        static bool a = false;
        
        public static bool IfIsPositiveCalculateFactorial(int x, out int a)
        {
            if (x > 0)
            {
                a = Math.Factorical(x);
                return true;
            }
            else
            {
                a = -1;
                return false;
            }
        }
    }
}

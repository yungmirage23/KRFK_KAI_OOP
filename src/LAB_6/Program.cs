namespace LAB_6
{
    class Ping : Message
    {
    }
    class TestMessage : Message
    {
        public string Message { get; set; }
    }
    class Message
    {

    }

    internal class Program
    {
        private static bool _ourVar = false;
        private static bool Func()
        {
            return true;
        }

        private static void Main(string[] args)
        {

            

            Console.ReadLine();
            int a = 5;

            var res = a switch
            {
                "BMW" => "Germany",
                2 => "Thursday",
                3 => "Thursday",
                4 => "Thursday",
                5 => "Thursday",
            };

            bool isEven;
            string isEvenString;
            isEvenString = a % 2 == 0 ? "Digit is event" : "Digit is not even";
        }


        public static bool ConvertToBool(short a)
        {
            if (a == 1)
            {
                return true;
            }
            else if(a== 0)
            {
                return false;
            }

            throw new ArgumentOutOfRangeException($"Bool must has value 1 or 0. Value vas: {a} ");
        }
        public static int FunctionSum()
        {
            throw new NotImplementedException();
        }

        public static void Function()
        {
            FunctionException();
        }

        public static bool FunctionTrue()
        {
            return true;
        }

        public static bool FunctionFalse()
        {
            return false;
        }

        public static bool FunctionException()
        {
            throw new ArgumentNullException("Hello is exception");
        }

        private class Test
        {
        }
    }
}
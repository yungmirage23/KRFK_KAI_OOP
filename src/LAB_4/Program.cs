namespace LAB_4
{

    internal partial class Program
    {

        private protected static void Main(string[] args)
        {
            var a = 4 % 2;
            var test = new Test2();
            test.A();

            //var person = new Person();
            //person.SetName("Олег").SetAge(25).ShowInfo();
        }
       
       
    }

    public class Test2
    {
        internal void A()
        {
            int a = 1;
            return;
            a++;
            Console.WriteLine(a);
        }
    }


    class Test : Program
    {
        public static string Value { get; set; }
        public string Value2 { get; set; }
        
        public void B()
        {
            A();
        }
        
        public static void TestMethod()
        {
           
            var sdosakd = 5;
            Value = string.Empty;
        }

        public override string ToString()
        {
            return Value + Value2;
        }
    }



   
}

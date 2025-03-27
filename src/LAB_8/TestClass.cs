namespace LAB_8
{
    internal class TestClass
    {
        public static void A()
        {
            B();
        }
        public static void B()
        {
            C();
        }
        public static void C()
        {
            var exception = new Exception("Exception occured");
            throw exception;
        }
    }
}
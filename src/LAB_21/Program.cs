namespace LAB_21
{
    internal partial class Program
    {
        public class Container<T>
        {
            public T Value { get; set; }

            public void ShowInfo()
            {
                Console.WriteLine($"Значення: {Value}, Тип: {Value.GetType().Name}");
            }
        }

        private static void Main(string[] args)
        {
            var cache = new Cache<IMessage>();
         

            Container<int> intBox = new Container<int> { Value = 42 };
            Container<string> strBox = new Container<string> { Value = "Hello" };

            cache.Set("text", new TextMessage());

            var value = intBox.Value;

            intBox.ShowInfo();
            strBox.ShowInfo();

        }
    }
}
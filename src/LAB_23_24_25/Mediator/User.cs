namespace LAB_23_24_25.Mediator
{
    public class User
    {


        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }

        public void Receive(string message) => Console.WriteLine($"{Name} отримав повідомлення: {message}");
    }
}

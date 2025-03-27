namespace LAB_12
{
    internal class Program
    {
        enum State
        {
            Online,
            Offline
        }

        class User
        {
            public string Name { get; set; }
            public readonly string Password;

            public State State => state;


            private State state = State.Offline;
            

            public User(string name, string password)
            {
                Name = name;
                this.Password = password;
            }
        }

        class LoginService
        {
            public event EventHandler<string> OnLogin;
            public List<User> Users { get; set; }


            public LoginService(List<User> users)
            {
                Users = users;
            }

            public User Login(string username, string password)
            {
                var user = Users.FirstOrDefault(x => x.Name == username);
                if (user == null)
                    throw new Exception("Invalid username");

                if(user.Password != password)
                    throw new Exception("Invalid password");

                OnLogin?.Invoke(this, user.Name);
                return user;
            }
        }


        public delegate void ClickHandler(ConsoleKeyInfo consoleKeyInfo);
        public static event ClickHandler OnKeyPressed;

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Потік {Thread.CurrentThread.ManagedThreadId}: {i}");
                Thread.Sleep(100); // Імітація затримки
            }
        }

        static void Main(string[] args)
        {
            var users = new List<User>() { new User("Andriy", "Qwerty123$"), new User("Dmytro", "Qwerty123$"), new User("Mykyta", "Qwerty123$") };

            var loginService = new LoginService(users);
            loginService.OnLogin += LoginService_OnLogin;

            var user = loginService.Login("Dmytro", "Qwerty123$");
            
        }

        private static void LoginService_OnLogin(object? sender, string e)
        {
            Console.WriteLine($"User {e} logged in");
        }
    }
}

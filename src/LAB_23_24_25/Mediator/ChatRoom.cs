namespace LAB_23_24_25.Mediator
{
    public class ChatRoom : IChatRoom
    {
        private readonly List<User> _users = new();

        public void Register(User user) => _users.Add(user);

        public void Send(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                    user.Receive(message);
            }
        }
    }
}

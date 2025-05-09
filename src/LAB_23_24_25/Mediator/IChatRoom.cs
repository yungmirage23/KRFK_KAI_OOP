namespace LAB_23_24_25.Mediator
{
    public interface IChatRoom
    {
        void Register(User user);
        void Send(string message, User sender);
    }
}

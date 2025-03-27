namespace LAB_6
{
    internal class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException() : base("User has less money ....")
        {
            
        }
    }
}

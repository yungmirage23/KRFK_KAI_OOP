namespace LAB_18.Core
{

    public class BankAccount(int id, string firstName, string secondName, decimal balance)
    {
        public int Id { get; set; } = id;
        public string FirstName { get; set; } = firstName;
        public string SecondName { get; set; } = secondName;
        public decimal Balance { get; set; } = balance;
    };
}

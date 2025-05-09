namespace LAB_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(200);

            car.Accelerate(50);
            car.Accelerate(50);
            car.Accelerate(50);
            car.Accelerate(51);


            var student = new Student();
            var name = student.Name;
            student.Name = "Dmytro";

            var repository = new BankAccountRepository();

            var account = new BankAccount
            {
                Id = 125124,
                FirstName = "Dmytro",
                LastName = "Kryvenko",
                Balance = 1000
            };
            var account2 = new BankAccount
            {
                Id = 241512,
                FirstName = "Anton",
                LastName = "Levenyuk",
                Balance = 1000
            };

            var account3 = new BankAccount
            {
                Id = 125124,
                FirstName = "123",
                LastName = "321",
                Balance = 0
            };

            repository.Add(account);

            repository.Add(account2);
            try
            {
                repository.Add(account3);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

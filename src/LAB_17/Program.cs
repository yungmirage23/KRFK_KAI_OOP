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

            car.Decelerate(150);
            car.Decelerate(50);


            var student = new Student();

            student.Name = "Dmytro";

            student.Age = 121;


            var studentName = student.Name;

            var studentAge = student.Age;

            var bankAccountRepository = new BankAccountRepository();

            var account = new BankAccount(15121312, "Dmytro", "Kryvenko", 0);
            var account2 = new BankAccount(12134313, "Oleh", "123", 0);

            bankAccountRepository.Add(account);
            bankAccountRepository.Add(account2);

            bankAccountRepository.RemoveById(15121312);

            try
            {
                var foundAccount = bankAccountRepository.GetById(15121312);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Account not found");
                Console.WriteLine(ex);
            }

        }
    }
}

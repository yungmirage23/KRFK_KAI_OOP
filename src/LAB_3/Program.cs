namespace LAB_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            //Task2();
            Task3();
        }

        //Тут виконуєте завдання №1
        private static void Task1()
        {
            int user_age = 20;
            string UserName = "Андрій";

            Console.WriteLine("Привіт, " + UserName + "! Твій вік: " + user_age);
        }

        //Тут виконуєте завдання №2
        //private static void Task2()
        //{
        //    int int = 10;      //  Не можна використовувати "int"

        //    string class = "Hi"; //  "class" - зарезервоване слово

        //    bool new = true;    //  "new" теж зарезервоване слово

        //    Console.WriteLine(int + " " + class + " " + new);
        //}

        //Тут виконуєте завдання №3
        private static void Task3()
        {
            string name = "Анна";
            int age = 25;
            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age);
        }
    }
}
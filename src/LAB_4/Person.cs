namespace LAB_4
{

    internal partial class Program
    {
        class Person
        {
            private string name;
            private int age;

            // Метод для встановлення імені
            public Person SetName(string name)
            {
                this.name = name; // Використання this для звернення до поля класу
                return this; // Повертає поточний об'єкт
            }

            // Метод для встановлення віку
            public Person SetAge(int age)
            {
                this.age = age;
                return this; // Повертає поточний об'єкт
            }

            // Метод для виводу інформації
            public void ShowInfo()
            {
                Console.WriteLine($"Ім'я: {name}, Вік: {age}");
            }
        }

    }
}

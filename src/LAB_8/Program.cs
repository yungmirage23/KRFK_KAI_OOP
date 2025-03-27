
namespace LAB_8
{
    internal class Program
    {
        private class Student
        {
            public int Age { get; set; }

            public int AvarageGrade { get; set; }

            public Student(int age, int avarage)
            {
                Age = age;
                AvarageGrade = avarage;
            }
        }

        private static void Main(string[] args)
        {
            var allDigits = new int[] { 1, 2, 5, 32, 23, -1, 4 };
            var ourStudent = new Student(23, 5);
            var ourStudent2 = ourStudent;
            Student[] allStudents = 
                new Student[] { new Student(18, 5), new Student(23, 4), new Student(17, 3), ourStudent, new Student(19, 3), new Student(20, 4), new Student(21, 2) };


            Array.Sort

            var filteredMas = allDigits.Where(x=>x > 3).Select(x=>x *2).First();
        }
    }
}
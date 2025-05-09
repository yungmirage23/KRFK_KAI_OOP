namespace LAB_17
{
    public class Student
    {
        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age => age;


        private int age;
        private string name;

        public Student()
        {
            age = 23;
        }
    }
}

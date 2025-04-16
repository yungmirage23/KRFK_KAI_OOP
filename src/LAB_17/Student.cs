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

        public int Age
        {
            get { return age; }
            set
            {
                if(value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 120");
                }
                age = value;
            }
        }


        private int age;
        private string name;
    }
}

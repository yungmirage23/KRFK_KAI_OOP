namespace LAB_11
{

    public class User
    {
        public int Id => id;

        private int id;

        public string Name { get; private set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public string? Email { get; set; }


        public List<Subsription> Subscriptions { get; set; }

        public User(int id)
        {
            this.id = id;
            //id = Random.Shared.Next();
        }

        public User(int id, string name, int age, int weight) : this(id)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void ChangeUserName(string newName)
        {
            if (newName == string.Empty)
            {
                throw new ArgumentNullException(newName);
            }

            Name = newName;
        }
    }
}
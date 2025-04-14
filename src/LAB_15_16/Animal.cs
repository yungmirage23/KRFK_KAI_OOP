namespace LAB_14
{

    public class Plane : Vehicle, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Plane is moving");
        }
    }
    public class Car : Vehicle, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Supercar : Car
    {
        public void MoveFast()
        {
            Console.WriteLine("Car is moving very fast");
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public abstract class Vehicle
    {
        public int Weight { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }
        public void Stop() 
        {
            Console.WriteLine("Vehicle stopped");
        }
    }

    public abstract class Animal
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Animal(int weight, int height, int age)
        {
            Weight = weight;
            Height = height;
            Age = age;
        }

        public abstract void MakeSound();
    }


    public class Dog : Animal
    {
        public string Name { get; set; }

        private ILogger logger;
        public Dog(ILogger logger,string name, int weight, int height, int age) : base(weight, height, age)
        {
            this.logger = logger;
            Name = name;
        }

        public override void MakeSound()
        {
            logger.Log("Bark");
        }
    }

    public class Cat : Animal
    {
        public Cat(int weight, int height, int age) : base(weight, height, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}

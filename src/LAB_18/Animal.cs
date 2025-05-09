
namespace LAB_18
{

    public interface IAnimal
    {
        void Speek();
    }
    public abstract class Animal
    {
        private sbyte _age;
        private string _name;

        public abstract void Speek();

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
        public void Walk()
        {
            Console.WriteLine("Animal is walking");
        }

    }
    public class Dog : Animal
    {
        public override void Speek()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    public class Cat : Animal
    {
        public override void Speek()
        {
            Console.WriteLine("Cat is meawing");
        }
    }
}

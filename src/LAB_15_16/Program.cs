using LAB_14;

class Program
{
    static async Task Main()
    {

        ILogger logger = new ConsoleLogger();

        logger.Log("Hello");
        var car = new Car();
        var plane = new Plane();
        var list = new List<IMovable>();

        list.Add(car);
        list.Add(plane);
        foreach (var item in list) 
        {
            item.Move();
        }
        logger.Log("Cars example");
        var dog = new Dog(logger,"Barsik",20,50,4);
        var cat = new Cat(10,30,3);

        var animals = new List<Animal>();
        animals.Add(cat);
        animals.Add(dog);

        var name = dog.Name;

        foreach(var animal in animals)
        {
            var type = animal.GetType();
            logger.Log($"Animal. Type: {type.Name} | AGE: {animal.Age} |  WEIGHT: {animal.Weight}|  HEIGHT: {animal.Height}");

            var dog1 = animal as Dog;
            if (dog1 != null)
            {
                logger.Log($"Name: {dog.Name}");
            }

            animal.MakeSound();
        }


        logger.Log(dog.Age);
        logger.Log(cat.Weight);
    }
}

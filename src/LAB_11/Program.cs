namespace LAB_11
{
    internal partial class Program
    {
        public struct Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public Colors Color { get; set; }

            public int Year { get; set; }

            public Car(string brand, string model)
            {
                Brand = brand;
                Model = model;
            }

            public Car(string brand, string model, int year) : this(brand, model)
            {
                Year = year;
            }

            public Car(string brand, string model, int year, Colors color)
                : this(brand, model, year)
            {
                Color = color;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Car is: Brand: {Brand}, Model: {Model}, Color: {Color}....");
            }
        }
        record Record(int A, int B);

        record struct Point(int x, int y)
        {
            public double DistanceTo(Point otherPoint)
            {
                var x1 = x;
                var y1 = y;
                var x2 = otherPoint.x;
                var y2 = otherPoint.y;

                var distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

                return distance;
            }
        }

        private readonly struct Triangle
        {
            public readonly int X;
            public readonly int Y;

            public readonly int Z;

            public Triangle(int x, int y, int z)
            {
                X = x; Y = y; Z = z;
            }
        }

        private static void Main()
        {



            var color = Colors.White;
            var colorStr = color.ToString();
            var color2 = Colors.Green;

            var car = new Car("BMW", "X5", 1999, Colors.White);
            car.ShowInfo();
            var point = new Point() { x = 2, y = 5 };
            var point2 = new Point(5, 10);

            var distance = point.DistanceTo(point2);

            var user = new User(23, "Dmytro", 40, 80);

            var type = user.GetType();

            var type2 = 23.GetType();
        }

        private static void Print(Car car)
        {
            car.Brand = "ABC";
        }

        private static void Print(Rectangle rectangle)
        {
            rectangle.X = 3;
            Console.WriteLine($"{rectangle.X}, {rectangle.Y}");
        }
    }
}
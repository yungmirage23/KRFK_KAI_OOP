namespace LAB_22
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public override string ToString() => $"Pizza with : Dough: {Dough}, Sauce: {Sauce}, Topping: {Topping}";
    }


    public class PizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder WithDough(string dough)
        {
            _pizza.Dough = dough;
            return this;
        }
        public PizzaBuilder AddSauce(string sauce)
        {
            _pizza.Sauce = sauce;
            return this;
        }
        public PizzaBuilder AddTopping(string topping)
        {
            _pizza.Topping = topping;
            return this;
        }

        private bool isBuild = false;
        public Pizza Build()
        {
            if (isBuild)
            {
                throw new InvalidOperationException("Pizza already built");
            }
            isBuild = true;

            return _pizza;
        }
    }

    public static class PizzaExtensions
    {
        public static Pizza CreateDefaultPizza(this PizzaBuilder builder)
        {
            return builder
                .WithDough("Тонке")
                .AddSauce("Томатний")
                .AddTopping("Салямі").Build();
        }
    }
}

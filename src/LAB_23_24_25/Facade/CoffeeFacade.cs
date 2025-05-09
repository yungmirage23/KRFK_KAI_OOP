namespace LAB_23_24_25.Facade
{
    public class CoffeeFacade
    {
        private readonly CoffeeMachine _coffeeMachine;
        private readonly WaterHeater _waterHeater;
        private readonly Grinder _grinder;

        public CoffeeFacade()
        {
            _coffeeMachine = new CoffeeMachine();
            _waterHeater = new WaterHeater();
            _grinder = new Grinder();
        }
        public void MakeCoffee()
        {
            _coffeeMachine.TurnOn();
            _grinder.GrindBeans();
            _waterHeater.HeatWater();
            _coffeeMachine.MakeCoffee();
            _coffeeMachine.TurnOff();
        }
    }
}

namespace LAB_17
{
    public class Car
    {
        public int Speed => speed;

        private int speed;

        public Car(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        private readonly int maxSpeed;

        public void Accelerate(int accelerateSpeed)
        {
            if (speed + accelerateSpeed > maxSpeed)
            {
                throw new InvalidOperationException($"Car can't accelerate more than {maxSpeed}");
            }
            speed += accelerateSpeed;
        }

        public void Decelerate(int decelerateSpeed)
        {
            if (speed - decelerateSpeed < 0)
            {
                throw new InvalidOperationException($"Car can't decelerate less than 0/kph");
            }

            speed -= decelerateSpeed;
        }
    }
}

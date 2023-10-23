namespace Lab6_1
{
    public class Car : Vehicle
    {
        public Car()
        {
            Speed = 60;
            Capacity = 4;
            Passengers = new List<Passenger>();
        }

        public override void Move()
        {
            Console.WriteLine("Driving a car...");
        }
    }
}

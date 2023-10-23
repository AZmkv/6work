namespace Lab6_1
{
    public class Bus : Vehicle
    {
        public Bus()
        {
            Speed = 40;
            Capacity = 30;
            Passengers = new List<Passenger>();
        }

        public override void Move()
        {
            Console.WriteLine("Taking the bus...");
        }
    }
}

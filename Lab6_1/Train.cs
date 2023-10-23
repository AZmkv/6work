namespace Lab6_1
{
    public class Train : Vehicle
    {
        public Train()
        {
            Speed = 80;
            Capacity = 200;
            Passengers = new List<Passenger>();
        }

        public override void Move()
        {
            Console.WriteLine("Taking the train...");
        }
    }
}

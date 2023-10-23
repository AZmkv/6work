namespace Lab6_1
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public List<Passenger> Passengers { get; set; }

        public abstract void Move();
    }
}

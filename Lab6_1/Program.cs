using Lab6_1;

class Program
{
    static void Main()
    {
        TransportNetwork network = new TransportNetwork();

        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        Route route = new Route("City A", "City B");

        network.SetRoute(route);
        network.OptimizeRoute();
        network.StartJourney();
    }
}
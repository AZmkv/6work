namespace Lab6_1
{
    public class TransportNetwork
    {
        public List<Vehicle> Vehicles { get; set; }
        public Route CurrentRoute { get; set; }

        public TransportNetwork()
        {
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void SetRoute(Route route)
        {
            CurrentRoute = route;
        }

        public void OptimizeRoute()
        {
            // Implement route optimization logic based on the type of transport
            Console.WriteLine("Optimizing route...");
        }

        public void StartJourney()
        {
            Console.WriteLine($"Journey from {CurrentRoute.StartPoint} to {CurrentRoute.EndPoint} begins.");

            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"Boarding vehicle with capacity of {vehicle.Capacity}.");

                // Add passengers to the vehicle
                for (int i = 0; i < vehicle.Capacity; i++)
                {
                    vehicle.Passengers.Add(new Passenger($"Passenger {i + 1}"));
                }
            }

            foreach (var vehicle in Vehicles)
            {
                vehicle.Move();
            }

            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"Disembarking from vehicle.");

                // Remove passengers from the vehicle
                vehicle.Passengers.Clear();
            }

            Console.WriteLine("Journey completed.");
        }
    }

}

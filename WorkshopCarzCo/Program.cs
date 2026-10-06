using System.Security.Cryptography.X509Certificates;

namespace WorkshopCarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehicle list
            List<Vehicle> vehicles = new List<Vehicle>(); // Create new list

            // Filtered vehicles list
            static List<T> FilterVehicles<T>(List<Vehicle> vehicles) where T : Vehicle
            {
                return vehicles.OfType<T>().ToList();
            }

            // Lägg till några fordon
            vehicles.Add(new Car("Volvo", "V60", 5));
            vehicles.Add(new Motorcycle("Harley-Davidson", "Street 750")); // has no doors by default
            vehicles.Add(new Truck("Scania", "R500", 3));
            vehicles.Add(new Car("Toyota", "Corolla", 4));

            // Skriv ut alla fordon
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.PrintInfo();

                //if (vehicle.HasDoors) // output for all vehicles but motorcycles
                //{
                //    Console.WriteLine($"Antal dörrar: {vehicle.DoorAmount}");
                    
                //}
                //else // output for motorcycles
                //{
                //    // Console.WriteLine($"Dörrar: Har inga dörrar.\n");
                //}    
            }

            // Filtrera och skriv ut bara bilar
            Console.WriteLine("\nBara bilar:");
            var cars = FilterVehicles<Car>(vehicles);
            foreach (var car in cars)
            {
                car.PrintInfo();
            }

            // Sälj ett fordon
            var vehicleToSell = vehicles.Find(v => v.Brand == "Toyota");
            if (vehicleToSell != null)
            {
                SellVehicle(vehicles, vehicleToSell);
            }

            // Skriv ut uppdaterad lista
            Console.WriteLine("\nUppdaterad lista efter försäljning:");
            foreach (var vehicle in vehicles)
            {
                vehicle.PrintInfo();
            }

            // Sell vehicles method
            static void SellVehicle(List<Vehicle> vehicles, Vehicle vehicle)
            {
                Console.WriteLine($"\nSäljer fordon: {vehicle}");
                vehicles.Remove(vehicle);
            }

            

        }
    }
}

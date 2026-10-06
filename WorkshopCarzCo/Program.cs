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

            vehicles.Add(new HastVagn(300, "oats", 3, "Ferrari", "Mustang", 2));
            vehicles.Add(new Buss(12,40,"diesel", "volvo", "nånting", 4));
            vehicles.Add(new Boat(200,10,9000,"viking", "galaxy", 200));




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

            // Sortera bland olika fordon
            Console.WriteLine("Fordon med fler än fyra dörrar.");
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.DoorAmount >= 4)
                {
                    vehicle.PrintInfo();
                }
                
                //switch (vehicle)
                //{
                //    case Car:
                //        if (vehicle.DoorAmount >= 4)
                //        {
                //            vehicle.PrintInfo();
                //        }
                //        break;

                //    case Truck:
                //        if (vehicle.DoorAmount >= 4)
                //        {
                //            vehicle.PrintInfo();
                //        }
                //        break;

                //    case Buss:
                //        if (vehicle.DoorAmount >= 4)
                //        {
                //            vehicle.PrintInfo();
                //        }
                //        break;

                //    case Boat:
                //        if (vehicle.DoorAmount >= 4)
                //        {
                //            vehicle.PrintInfo();
                //        }
                //        break;

                //    case HastVagn:
                //        break;

                //    case Motorcycle:
                //        break;

                //    default:
                //        Console.WriteLine("Inte ett av de tillåtna fordonen.");
                //        break;
                //}
                // Only allowed vehicles
                

            }



            //Console.WriteLine("\nBara bilar:");
            //var cars = FilterVehicles<Car>(vehicles);
            //foreach (var car in cars)
            //{
            //    car.PrintInfo();
            //}

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

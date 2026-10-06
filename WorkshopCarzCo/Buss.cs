using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public class Buss : Vehicle
    {
        public int Passangers { get; set; } = 0;
        public int Capacity { get; set; } = 0;
        public string Fuel { get; set; } = "unknown";
        public Buss(int passangers, int capacity, string fuel, string brand, string model, int doorAmount) : base(brand, model, doorAmount)
        {
            Passangers = passangers;
            Capacity = capacity;
            Fuel = fuel;

        }

        public override void Drive()
        {
            Console.WriteLine($"Bussen av märket {Brand} och modellen {Model} kör på gatan.");
        }
        public override void PrintInfo() // Abstract method
        {
            Console.WriteLine($"\nFORDON: {GetType().Name}\n" +
                $"Antal passagerare: {Passangers}\n"+
                $"Kapacitet:{Capacity}\n"+
                $"Bränsletyp: {Fuel}\n"+
                                  $"Märke: {Brand}\n" +
                                  $"Modell: {Model}");

            if (HasDoors) // output for all vehicles but motorcycles
            {
                Console.WriteLine($"Antal dörrar: {DoorAmount}");

            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public class Motorcycle : Vehicle
    {
        // Constructor
        public Motorcycle(string brand, string model) : base(brand, model)
        {
            HasDoors = false;
        }

        public override void Drive()
        {
            Console.WriteLine($"Motorcykeln av märket {Brand} och modellen {Model} kör på gatan.");
        }
    }
}

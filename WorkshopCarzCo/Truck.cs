using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public class Truck : Vehicle
    {
        // Constructor
        public Truck(string brand, string model, int doorAmount) : base(brand, model, doorAmount)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"Lastbilen av märket {Brand} och modellen {Model} kör på gatan.");
        }
    }
}

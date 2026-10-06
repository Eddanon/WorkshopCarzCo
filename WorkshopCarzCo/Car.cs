using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public class Car : Vehicle
    {
        // Constructor
        public Car(string brand, string model, int doorAmount) : base(brand, model, doorAmount)
        {

        }


        public override void Drive()
        {
            Console.WriteLine($"Bilen av märket {Brand} och modellen {Model} kör på gatan.");
        }
    }
}

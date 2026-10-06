using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public class HastVagn : Vehicle
    {
        public int Weight { get; set; } = 0;
        public string Food { get; set; } = "unkown";
        public int Age { get; set; } = 0;


        public HastVagn(int weight, string food, int age, string brand, string model, int doorAmount) : base(brand, model, doorAmount)
        {
            Weight = weight;
            Food = food;
            Age = age;

        }

        public override void Drive()
        {
            Console.WriteLine($"Hästen av märket {Brand} och modellen {Model} kör på gatan.");
        }
        public override void PrintInfo() // Abstract method
        {
            Console.WriteLine($"\nFORDON: {GetType().Name}\n" +
                $"Vikt: {Weight}\n" +
                $"Bränsletyp:{Food}\n" +
                $"Ålder: {Age}\n" +
                                  $"Märke: {Brand}\n" +
                                  $"Modell: {Model}");

            if (HasDoors) // output for all vehicles but motorcycles
            {
                Console.WriteLine($"Antal dörrar: {DoorAmount}");

            }
        }
    }
}
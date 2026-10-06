using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public class Boat : Vehicle
    {
        public int Length { get; set; } = 0;
        public int Depth { get; set; } = 0;
        public int Range { get; set; } = 0;
        public Boat(int length, int depth, int range, string brand, string model, int doorAmount) : base(brand, model, doorAmount)
        {
            Length = length;
            Depth = depth;
            Range = range;
        }

        public override void Drive()
        {
            Console.WriteLine($"Hästen av märket {Brand} och modellen {Model} kör på gatan.");
        }
        public override void PrintInfo() // Abstract method
        {
            Console.WriteLine($"\nFORDON: {GetType().Name}\n" +
                $"Skrov längd: {Length}\n" +
                $"Sjösatt djup:{Depth}\n" +
                $"Räckvidd: {Range}\n" +
                                  $"Märke: {Brand}\n" +
                                  $"Modell: {Model}");

            if (HasDoors) // output for all vehicles but motorcycles
            {
                Console.WriteLine($"Antal dörrar: {DoorAmount}");

            }
        }
    }
}

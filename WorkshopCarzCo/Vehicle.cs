using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCarzCo
{
    public abstract class Vehicle : IDriveable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        // Amount of doors
        public bool HasDoors { get; set; } = true;
        public int DoorAmount { get; set; } /*= 2; // Default value*/

        // Constructor for motorcycles
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
            // Has no doors
        }
        
        // Constructor for cars and trucks
        public Vehicle(string brand, string model, int doorAmount)
        {
            Brand = brand;
            Model = model;
            DoorAmount = doorAmount;
        }

        public abstract void Drive(); // Abstract method

        public virtual void PrintInfo() // Abstract method
        {
            Console.WriteLine($"\nFORDON: {GetType().Name}\n" +
                                  $"Märke: {Brand}\n" +
                                  $"Modell: {Model}");

            if (HasDoors) // output for all vehicles but motorcycles
            {
                Console.WriteLine($"Antal dörrar: {DoorAmount}");

            }
        }

    }
}

using System;

namespace ConsoleApp1.Strategy
{
    class Peasant : Citizen
    {
        public int CarryWeight;

        public Peasant(string name) : base(name, 30, 0, 4)
        {
            Profession = "Peasant";
            CarryWeight = 100;
        }

        public void PlantGrower()
        {
            Console.WriteLine($"{Name} - {Profession} is works in the field.");
        }
    }
}

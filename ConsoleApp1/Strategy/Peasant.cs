using System;

namespace ConsoleApp1.Strategy
{
    class Peasant : Citizen
    {
        public int CarryWeight;

        public Peasant(string name) : base(name, 30, 0, 4)
        {
            profession = "Peasant";
            CarryWeight = 100;
            profession = "Peasant";
        }

        public void PlantGrower()
        {
            Console.WriteLine($"{name} - {profession} is works in the field.");
        }
    }
}

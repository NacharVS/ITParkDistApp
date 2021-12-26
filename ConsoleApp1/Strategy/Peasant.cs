using System;

namespace ConsoleApp1.Strategy
{
    class Peasant : MovableUnits
    {
        public int CarryWeight;

        public Peasant(string name) : base(name, 30, 0, "Worker", 4)
        {           
            CarryWeight = 100;
        }

        public void Work()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Can carry {CarryWeight} pounds");
        }
    }
}

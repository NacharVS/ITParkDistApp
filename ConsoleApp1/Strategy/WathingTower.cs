using System;

namespace ConsoleApp1.Strategy
{
    class WathingTower : Buildings
    {
        public WathingTower() : base("Tower", 100, 20)
        {
        }

        public void Observe()
        {
            Console.WriteLine($"{name} is Observing.");
        }

    }
}

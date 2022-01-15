using System;

namespace ConsoleApp1.Strategy
{
    class WathingTower : Buildings
    {
        public WathingTower() : base("WathingTower", 100, 20)
        {
        }

        public void Observe()
        {
            Console.WriteLine($"{Name} is Observing.");
        }

    }
}

using System;

namespace ConsoleApp1.Strategy
{
    class WathingTower : Buildings
    {
        public WathingTower() : base("WathingTower", 200, 20)
        {
        }

        public void Observe()
        {
            Console.WriteLine($"{Name} is Observing.");
        }

    }
}

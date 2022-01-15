using System;

namespace ConsoleApp1.Strategy
{
    class WathingTower : Buildings
    {
        public WathingTower(string name) : base(name, 200, 20)
        {
        }

        public void Observe()
        {
            Console.WriteLine($"{Name} is Observing.");
        }

    }
}

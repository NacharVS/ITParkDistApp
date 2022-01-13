using System;

namespace ConsoleApp1.Strategy
{
    class WatchingTower : Buildings
    {
        public WatchingTower() : base("Tower", 100, 20)
        {
        }

        public void Observe()
        {
            Console.WriteLine($"{name} is Observing. Statement {wall}, {Health}, {armor}");
        }
    }
}

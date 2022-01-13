using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        internal double maxHealth;
        internal double health;
        public double armor;

        protected Unit(string name, double maxHealth, double armor)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.health = maxHealth;
            this.armor = armor;
            Creation();
        }

        public void Creation()
        {
            Console.WriteLine($"{name} is created");
        }

        public void Termination()
        {          
            Console.WriteLine($"{name} is terminated");
        }

        public void Info()
        {
            Console.WriteLine($"Name:{name}/ Health:{health}/ armor:{armor}");
        }
    }
}

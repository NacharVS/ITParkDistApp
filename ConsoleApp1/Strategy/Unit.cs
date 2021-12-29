using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        public double maxHealth;
        public double health;
        public double armor;

        protected Unit(string name, double health, double armor)
        {
            this.name = name;
            this.maxHealth = health;
            this.health = health;
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

using System;

namespace ConsoleApp1.Strategy
{
    class Hospital:Buildings
    {
        public int minHeal;
        public int maxHeal;
        public int Mana;
        public Hospital(string name, int health, int armor, int mana, int min, int max) : base(name, health, armor)
        {
            minHeal = min;
            maxHeal = max;
            Mana = mana;
        }
        public void UnitHeal(Hospital hospital, Peasant peasant, Random rnd)
        {
            var currentUnitHP = peasant.health;
            double currentHeal = Convert.ToDouble(rnd.Next(minHeal, maxHeal));
            int maxMana = hospital.Mana;
            if (currentUnitHP >= 30)
                Console.WriteLine($"{peasant.name} with full HP");
            else if ((30 - currentUnitHP) >= currentHeal)
            {
                peasant.health += currentHeal;
                hospital.Mana -= 100;
                Console.WriteLine($"{name} heal {peasant.name} with {currentHeal} points of heal. (mana:{hospital.Mana}/1000)");
            }
            else
            {
                hospital.Mana -= 100;
                peasant.health += (30 - currentUnitHP);
                Console.WriteLine($"{name} heal {peasant.name} up to {(30 - currentUnitHP)} points of heal. (mana:{hospital.Mana}/1000)");
            }

        }
        public void Termination()
        {
            Console.WriteLine($"{name} is terminated");
        }
    }
}

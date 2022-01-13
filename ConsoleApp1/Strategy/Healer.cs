using System;

namespace ConsoleApp1.Strategy
{
    internal class Healer : MovableUnits
    {
        public int minHeal;
        public int maxHeal;
        public int Mana;
        public Healer (string name, int health, int armor, string professionParam, int speedParam, int min, int max, int mana) : base(name, health, armor, professionParam, speedParam)
        {
            minHeal = min;
            maxHeal = max;
            Mana = mana;
        }
        public void UnitHeal (Healer healer, Peasant peasant, Random rnd)
        {
            var currentUnitHP = peasant.Health;
            double currentHeal = Convert.ToDouble(rnd.Next(minHeal, maxHeal));
            int maxMana = healer.Mana;
            if (currentUnitHP >= 30)
                Console.WriteLine($"{peasant.name} with full HP");
            else if ((30-currentUnitHP)>= currentHeal)
            {
                peasant.Health += currentHeal;
                healer.Mana -= 50;
                Console.WriteLine($"{name} heal {peasant.name} with {currentHeal} points of heal. (mana:{healer.Mana}/200)");
            }
            else
            {
                healer.Mana -= 50;
                peasant.Health += (30 - currentUnitHP);
                Console.WriteLine($"{name} heal {peasant.name} up to {(30 - currentUnitHP)} points of heal. (mana:{healer.Mana}/200)");
            }
        }
        public void Heal (MovableUnits unit, Random rnd)
        {
            double currentHeal = Convert.ToDouble(rnd.Next(minHeal, maxHeal));
            unit.Health += currentHeal;
        }
    }
}

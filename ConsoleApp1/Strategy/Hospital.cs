using System;

namespace ConsoleApp1.Strategy
{
    class Hospital:Buildings
    {
        public int minHeal;
        public int maxHeal;
        public int currentMana;
        private int _maxMana;
        public Hospital(string name, int health, int armor, int mana, int min, int max) : base(name, health, armor)
        {
            minHeal = min;
            maxHeal = max;
            currentMana = mana;
            _maxMana = mana;
        }
        public void UnitHeal(Hospital hospital, MovableUnits unit, Random rnd)
        {
            var currentUnitHP = unit.Health;
            double currentHeal = Convert.ToDouble(rnd.Next(minHeal, maxHeal));
            int maxMana = hospital._maxMana;
            if (currentUnitHP >= 30)
                Console.WriteLine($"{unit.name} with full HP");
            else if ((30 - currentUnitHP) >= currentHeal)
            {
                unit.Health += currentHeal;
                hospital.currentMana -= 100;
                Console.WriteLine($"{name} heal {unit.name} with {currentHeal} points of heal. (mana:{hospital.currentMana}/{hospital._maxMana})");
            }
            else
            {
                hospital.currentMana -= 100;
                unit.Health += (30 - currentUnitHP);
                Console.WriteLine($"{name} heal {unit.name} up to {(30 - currentUnitHP)} points of heal. (mana:{hospital.currentMana}/{hospital._maxMana})");
            }
        }
        public void Termination()
        {
            Console.WriteLine($"{name} is terminated");
        }
    }
}

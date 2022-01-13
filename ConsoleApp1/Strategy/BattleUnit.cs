using System;

namespace ConsoleApp1.Strategy
{
    class BattleUnit : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public BattleUnit(string name, int health, int armor, string professionParam, int speedParam, int min, int max) : base(name, health, armor, professionParam, speedParam)
        {
            minDamage = min;
            maxDamage = max;
        }

        public void MeeleeAttack(Peasant peasant, Random rnd)
        {
            if (peasant.health <= 0)
                peasant.Termination();
            else
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
                peasant.health -= currentDamage;
                Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
            }

        }

        public void MeeleeAttack(Buildings building, Random rnd)
        {
            if (building.health <= 0)
                building.Termination();
            else
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
                building.health -= currentDamage;
                Console.WriteLine($"{name} attack {building.name} with {currentDamage} points of damage");
            }

        }

        public void Upgrade()
        {
            if (lvl == 0)
            {
                minDamage += 1;
                maxDamage += 2;
                lvl++;
            }
        }
    }
}

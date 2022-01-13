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

        public void MeeleeAttack(MovableUnits unit, Random rnd)
        {
            if (unit.Health <= 0)
                unit.Termination();
            else
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
                unit.Health -= currentDamage;
                Console.WriteLine($"{name} attack {unit.name} with {currentDamage} points of damage");
            }

        }

        public void MeeleeAttack(Buildings building, Random rnd)
        {
            if (building.Health <= 0)
                building.Termination();
            else
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
                building.Health -= currentDamage;
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

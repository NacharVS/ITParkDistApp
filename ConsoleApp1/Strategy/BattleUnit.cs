using System;

namespace ConsoleApp1.Strategy
{
    class BattleUnit : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public BattleUnit(string name, double health, double armor, int speed, int min, int max) : base(name, health, armor, speed)
        {
            minDamage = min;
            maxDamage = max;
        }

        public void MeleeAttack(MovableUnits unit, Random rnd)
        {
            int currentDamage = rnd.Next(minDamage, maxDamage);
            unit.Wound(currentDamage);
            Console.WriteLine($"{name} attack {unit.name} with {currentDamage} points of damage");
        }

        
        public void Upgrade()
        {
            if(lvl == 0)
            {
                minDamage += 1;
                maxDamage += 2;
                lvl++;
            }
        }
    }
}

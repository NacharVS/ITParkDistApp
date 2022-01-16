using System;

namespace ConsoleApp1.Strategy
{
    class BattleUnit : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public BattleUnit(string name, int health, int armor, string professionParam, int speedParam, int minDamage, int maxDamage) : base(name, health, armor, professionParam, speedParam)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public double MleeAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;

        }

        public double Attack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            return currentDamage;
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

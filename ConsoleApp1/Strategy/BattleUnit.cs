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

        public virtual double MeeleeAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            Console.WriteLine($"    {name} attacks (meelee) with {currentDamage} damage");
            return currentDamage;
        }
        public virtual double Attack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            Console.WriteLine($"    {name} attacks (normal) with {currentDamage} damage");
            return currentDamage;
        }
        public virtual double BuildingAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            Console.WriteLine($"    {name} attacks (building) with {currentDamage} damage");
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

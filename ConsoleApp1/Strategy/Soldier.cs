using System;

namespace ConsoleApp1.Strategy
{
    class Soldier : MovableUnits
    {
        public int minDamage;
        public int maxDamage;

        public Soldier(string name) : base(name, 60, 5, "Soldier", 5)
        {
            minDamage = 2;
            maxDamage = 7;
        }

        public void AttackPeasant(Peasant peasant, Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
            peasant.health -= currentDamage;
            Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
            if (peasant.health <= 0)
                peasant.Termination();

        }

        public void AttackSoldier()
        {

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

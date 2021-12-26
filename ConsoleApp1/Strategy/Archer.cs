using System;

namespace ConsoleApp1.Strategy
{
    internal class Archer : BattleUnit
    {
        int arrows;
        int minRangeDamage;
        int maxRangeDamage;
        public Archer(string name) : base(name, 45, 0, "Shooter", 7,1,2)
        {
            minRangeDamage = 4;
            maxRangeDamage = 12;
        }
        public void RangeAttack(Peasant peasant, Random rnd)
        {
            if (arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minDamage, maxDamage));
                peasant.health -= currentDamage;
                Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
                arrows--;
                if (peasant.health <= 0)
                    peasant.Termination();
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MleeAttack(peasant,rnd);
            }
        }
    }
}

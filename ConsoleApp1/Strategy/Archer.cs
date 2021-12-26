using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : BattleUnit
    {
        int arrows;
        int minRangeDamage;
        int maxRangeDamage;

        public Archer(string name) : base(name, 45, 0, "shooter", 7, 1, 2)
        {
            arrows = 5;
            minRangeDamage = 4;
            maxRangeDamage = 12;
        }

        public void RangeAttack(Peasant peasant, Random rnd)
        {
            if (arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minRangeDamage, maxRangeDamage));
                peasant.health -= currentDamage;
                Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
                arrows--;
                if (peasant.health <= 0)
                    peasant.Termination();
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MleeAttack(peasant, rnd);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class Archer : BattleUnit    // Лучник
    {
        
        public int arrows;   //количество стрел
        public int minRangeDamage;  //мак урон рукой.
        public int maxRangeDamage;  //мин урон рукой.

        public Archer(string name) : base(name, 45, 0, 7, "Shooter", 1, 2)
        {
            arrows = 5;
            minRangeDamage = 4;
            maxRangeDamage = 12;
        }

        public void RangeAttack(Peasant peasant, Random rnd) //атака стрелой лучника
        {
            if (arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minRangeDamage, maxRangeDamage));
                peasant.health -= currentDamage;
                Console.WriteLine($"{name} attack, {peasant.name} with, {currentDamage} point of damage");
                arrows -- ;
                if (peasant.health <= 0)
                {
                    peasant.Termination();
                }
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MleeAttack(peasant, rnd);
            }
        }
        
    }
}

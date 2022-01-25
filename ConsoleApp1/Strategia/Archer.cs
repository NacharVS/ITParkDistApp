using ConsoleApp1.Стратегия;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
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

        public void RangeAttack(MovadelUnits unit, Random rnd) //атака стрелой лучника
        {
            if (arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(minRangeDamage, maxRangeDamage));
                unit.health -= currentDamage;
                Console.WriteLine($"{name} attack, {unit.name} with, {currentDamage} point of damage");
                arrows -- ;
                if (unit.health <= 0)
                {
                    unit.Termination();
                }
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MleeAttack(rnd);
            }
        }
        
    }
}

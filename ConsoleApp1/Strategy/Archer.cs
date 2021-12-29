using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : BattleUnit
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _maxRangeDamage;

        public Archer(string name) : base(name, 45, 0, "shooter", 7, 1, 2)
        {
            _arrows = 5;
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
        }

        public void RangeAttack(Peasant peasant, Random rnd)
        {
            if (peasant.health > 0)
            {
                if (_arrows > 0)
                {
                    double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
                    peasant.health -= currentDamage;
                    Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
                    _arrows--;
                    if (peasant.health <= 0)
                        peasant.Termination();

                }
                else
                {
                    Console.WriteLine("Arrows is empty");
                    MleeAttack(peasant, rnd);
                }
            }
            else
                if (peasant.health <= 0)
                peasant.Termination();
        }
    }
}

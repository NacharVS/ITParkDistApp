using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class Archer : BattleUnit
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _MaxRangeDamage;

        public Archer (string name) : base(name,45, 0, "Shooter",7, 1,2)
        {
            _arrows=5;
            _minRangeDamage =4;
            _MaxRangeDamage=12;
        }
        public void RangeAttack(Peasant peasant, Random rnd)
        {
            if (_arrows > 0)
            {   double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _MaxRangeDamage));
                peasant.health -= currentDamage;
                Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
                _arrows--;
                if (peasant.health <= 0)
                {
                    peasant.Termination();
                }
                Console.WriteLine("Continues hand-to-hand combat!");
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MleeAttack(peasant, rnd);
            }

        }
    }
}

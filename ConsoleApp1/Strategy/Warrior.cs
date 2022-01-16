using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : BattleUnit
    {
        private bool _rage = false;       

        public Warrior(string name) : base(name, 90, 10, "soldier", 5, 2, 8)
        {
        }

        public override double MleeAttack(Random rnd)
        {          
            if(Health > 0.4*_maxHealth && _rage == false)
            {
                return base.MleeAttack(rnd);
            }
            else
            {
                _rage = true;
                Console.WriteLine($"{name} RAGE!");
                return base.MleeAttack(rnd) * 2;
            }
        }
    }
}

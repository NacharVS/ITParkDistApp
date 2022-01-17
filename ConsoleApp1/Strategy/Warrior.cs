using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : BattleUnit
    {
        private bool _rage;
        
        public Warrior(string name) : base(name, 90, 3, 5, 2, 10)
        {

        }

        public override double Health
        {
            get => base.Health;

            set
            {
                base.Health = value;

                if (Health < 0.3 * MaxHealth && Health > 0)
                {
                    _rage = true;
                }

                else
                {
                    _rage = false;
                }
            }
        }

        public override double Attack(Random rnd)
        {
            if (_rage)
            {
                Console.WriteLine($"{Name} RAGE!");
                return base.MeleeAttack(rnd) * 2;
            }

            else
            {
                return base.MeleeAttack(rnd);
            }
        }
    }
}

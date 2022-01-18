using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : BattleUnit
    {
        //private bool _rage;
        //private int _rageK;
        
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
                    Rage = 2;
                    Console.WriteLine($"{Name} RAGE!");
                }

                else
                {
                    Rage = 1;
                }
            }
        }

        public override double Attack(Random rnd)
        {
            return base.MeleeAttack(rnd);
        }
    }
}

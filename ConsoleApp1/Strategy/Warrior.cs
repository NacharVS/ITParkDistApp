using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : BattleUnit
    {
        public Warrior(string name) : base(name, 60, 3, 5, 2, 10)
        {

        }

        public override double Attack(Random rnd)
        {
            return MeleeAttack(rnd);
        }
    }
}

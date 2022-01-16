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
        public override double Health { get => base.Health; set => base.Health = value; }
        public Warrior(string name) : base(name, 420, 2, "soldier", 5, 7, 18)
        {
        }
    }
}

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

        

        public Warrior(string name) : base(name, 90, 10, "soldier", 5, 2, 8)
        {
        }
    }
}

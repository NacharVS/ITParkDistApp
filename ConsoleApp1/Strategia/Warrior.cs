using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class Warrior : BattleUnit
    {
        private bool _rage;
        public Warrior(string name) : base(name, 90, 10, 5, "Warrior", 2, 8)
        {
        }
    }
}

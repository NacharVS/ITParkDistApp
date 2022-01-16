using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Catapult : BattleUnit
    {
        public Catapult(string name) : base(name, 120, 6, "catapult", 3, 12, 21)
        {
        }
    }
}

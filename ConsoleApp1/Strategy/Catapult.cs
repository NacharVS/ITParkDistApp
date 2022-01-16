using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Catapult : BattleUnit
    {
        internal override bool IsCatapult => true;

        public Catapult() : base("Catapult", 200, 20, "WallBreaker", 4, 30, 90)
        {
        }


    }
}

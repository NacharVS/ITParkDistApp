using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Soldier : BattleUnit
    {
        public Soldier(string name) : base(name, 90, 3, "Swordsman", 3, 7, 10)
        { 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Shaman : BattleUnit
    {
        public Shaman(string name) : base(name, 50, 5, "Shaman", 7, 1, 3)
        {
        }

        public void HealhBuff(BattleUnit unit)
        {
            if (!unit.IsHealthBoosted)
            {
                unit._maxHealth = unit._maxHealth + unit._maxHealth * 0.5;
                unit.IsHealthBoosted = !unit.IsHealthBoosted;
            }              
        }
    }
}

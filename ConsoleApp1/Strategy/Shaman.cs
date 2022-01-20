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

        public void FrenzyBuff(BattleUnit unit)
        {
            if (!unit.IsFrenzy)
            {
                unit.minDamage = Convert.ToInt32(unit.minDamage * 1.5);
                unit.maxDamage = Convert.ToInt32(unit.maxDamage * 1.5);
                unit.Armor = Convert.ToInt32(unit.Armor * 0.5);
                unit.IsFrenzy = !unit.IsFrenzy;
            }
        }
    }
}

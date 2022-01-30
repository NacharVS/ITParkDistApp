using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Shaman :BattleUnits
    {
        public Shaman(string name) : base(name, 50, 5, "Шаман", 7, 1, 3) /*Конструктор шамана*/
        {
        }
        public void HeathBuff(BattleUnits unit)
        {
            if (!unit.IsHealthBoosted)
            {

                unit.MaxHealth = unit.MaxHealth + unit.MaxHealth * 0.5;
                unit.IsHealthBoosted = !unit.IsHealthBoosted;
            }

        }

        public void FrenzyBuff(BattleUnits unit)
        {
            if (!unit.IsFrenzy)
            {
                unit.minDamage = Convert.ToInt32(unit.minDamage * 1.5);
                unit.maxDamage = Convert.ToInt32(unit.maxDamage * 1.5);
                unit.armor = Convert.ToInt32(unit.armor * 0.5);
                unit.IsFrenzy = !unit.IsFrenzy;
            }

        }
    }
}

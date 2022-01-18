using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Shaman : Citizen
    {
        public Shaman(string name) : base(name, 60, 0, 6)
        {
            Profession = "Shaman";
        }

        public void BoostHealth(MovableUnits unit)
        {
            if (!unit.IsBoostHealth)
            {
                unit.MaxHealth *= 1.5;
                unit.Health = unit.MaxHealth;

                unit.IsBoostHealth = true;
            }
        }

        public void Frenzy(BattleUnit unit)
        {
            if (!unit.IsFrenzy)
            {
                unit.Frenzy = 1.5;
                unit.Armor *= 0.5;

                unit.IsFrenzy = true;
            }
        }

        public void StoneSkin(MovableUnits unit)
        {
            if (!unit.IsStoneSkin)
            {
                unit.Armor *= 2;
                unit.Speed *= 0.5;

                unit.IsStoneSkin = true;
            }
        }
    }










    // Реализовать новый юнит Shaman которыйможет накидывать ряд усилений. 
    // 1. BoostHealth - Увеличивает максимальное здоровье на 50%
    // 2. Frenzy - Увеличивает показатель урона на 1,5 и снижает показатель защиты 0.5
    // 3. StoneSkin - увеличивает показатель защиты в 2 раза, и снижает скорость в 2 раза
    // *все усиления могут накладывать только 1 раз на 1 юнита (не стакаються)
}

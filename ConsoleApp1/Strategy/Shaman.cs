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
                Console.WriteLine($"health of {unit.name} has been upgraded {unit.Health}");
            }
            else Console.WriteLine($"{unit.name} cannot use Shaman to improve his health anymore");
        }

        public void FrenzyBuff(BattleUnit unit)
        {
            if (!unit.IsFrenzy)
            {
                unit.minDamage = Convert.ToInt32(unit.minDamage * 1.5);
                unit.maxDamage = Convert.ToInt32(unit.maxDamage * 1.5);
                unit.Armor = Convert.ToInt32(unit.Armor * 0.5);
                unit.IsFrenzy = !unit.IsFrenzy;
                Console.WriteLine($"Damage of {unit.name} has been upgraded");
                unit.Info();
            }
            else Console.WriteLine($"{unit.name} cannot use Shaman to improve his damage anymore");

        }

        public void StoneSkin(BattleUnit unit)
        {
            if (!unit.IsStoneSkin)
            {
                unit.Armor *= 2;
                unit.speed = Convert.ToInt32(unit.speed * 0.5);
                                
                Console.WriteLine($"Armor of {unit.name} has been upgraded");
                unit.Info();
            }
            else Console.WriteLine($"{unit.name} cannot use Shaman to improve his armor anymore");

        }




        //private List<Unit> bootHealth = new List<Unit>();                   //списки воспользовавшимися
        //private List<BattleUnit> frenzy = new List<BattleUnit>();
        //private List<MovableUnits> stoneSkin = new List<MovableUnits>();
        //public Shaman(string name) : base(name, 50, 5, "Shaman", 7)
        //{

        //}

        //public void BoostHealth(Unit unit)
        //{
        //    if (bootHealth.Contains(unit) == false)
        //    {
        //        unit.MaxHealth *= 1.5;
        //        unit.Health *= 1.5;

        //        bootHealth.Add(unit);
        //        Console.WriteLine($"health of {unit.name} has been upgraded {unit.Health}");
        //    }
        //    else Console.WriteLine($"{unit.name} cannot use Shaman to improve his health anymore");

        //}
        //public void Frenzy(BattleUnit unit)
        //{
        //    if (frenzy.Contains(unit) == false)
        //    {
        //        unit.minDamage = Convert.ToInt32(unit.minDamage * 1.5);
        //        unit.maxDamage = Convert.ToInt32(unit.maxDamage * 1.5);
        //        unit.Armor = Convert.ToInt32(unit.Armor * 0.5);
        //        frenzy.Add(unit);
        //        Console.WriteLine($"Damage of {unit.name} has been upgraded");
        //        unit.Info();
        //    }
        //    else Console.WriteLine($"{unit.name} cannot use Shaman to improve his damage anymore");

        //}




    }
}

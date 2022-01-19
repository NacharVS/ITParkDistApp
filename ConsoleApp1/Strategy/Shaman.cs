using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Shaman : MovableUnits
    {
        private List<Unit> bootHealth = new List<Unit>();                   //списки воспользовавшимися
        private List<BattleUnit> frenzy = new List<BattleUnit>();
        private List<MovableUnits> stoneSkin = new List<MovableUnits>();
        public Shaman(string name) : base(name, 50, 5, "Shaman", 7)
        {

        }

        public void BoostHealth(Unit unit)
        {
            if (bootHealth.Contains(unit) == false)
            {
                unit.MaxHealth *= 1.5;
                unit.Health *= 1.5;
                
                bootHealth.Add(unit);
                Console.WriteLine($"health of {unit.name} has been upgraded {unit.Health}");
            }
            else Console.WriteLine($"{unit.name} cannot use Shaman to improve his health anymore");
            
        }
        public void Frenzy(BattleUnit unit)
        {
            if (frenzy.Contains(unit) == false)
            {
                unit.minDamage = Convert.ToInt32(unit.minDamage * 1.5);
                unit.maxDamage = Convert.ToInt32(unit.maxDamage * 1.5);
                unit.Armor = Convert.ToInt32(unit.Armor * 0.5);
                frenzy.Add(unit);
                Console.WriteLine($"Damage of {unit.name} has been upgraded");
                unit.Info();
            }
            else Console.WriteLine($"{unit.name} cannot use Shaman to improve his damage anymore");

        }

        public void StoneSkin(MovableUnits unit)
        {
            if (stoneSkin.Contains(unit) == false)
            {
                unit.Armor *= 2;
                unit.speed = Convert.ToInt32(unit.speed * 0.5);
                
                stoneSkin.Add(unit);
                Console.WriteLine($"Armor of {unit.name} has been upgraded");
                unit.Info();
            }
            else Console.WriteLine($"{unit.name} cannot use Shaman to improve his armor anymore");

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        public static void UnitAttack (BattleUnit unit1, MovableUnits unit2)
        {
            while (unit1.Health > 0 & unit2.Health > 0)
            {
                var rnd = new Random();
                unit1.MeeleeAttack(unit2, rnd);
                unit1.Info();
                unit2.Info();
            }
        }
        public static void UnitAttack(BattleUnit unit1, BattleUnit unit2)
        {
            while (unit1.Health > 0 & unit2.Health > 0)
            {
                var rnd = new Random();
                unit1.MeeleeAttack(unit2, rnd);
                unit2.Info();
                unit2.MeeleeAttack(unit1, rnd);
                unit1.Info();
            }
        }
        public static void UnitAttack(Archer unit1, BattleUnit unit2)
        {
            while (unit1.Health > 0 & unit2.Health > 0)
            {
                var rnd = new Random();
                unit1.RangeAttack(unit2, rnd);
                unit2.Info();
                unit2.MeeleeAttack(unit1, rnd);
                unit1.Info();
            }
        }
        public static void UnitAttack(BattleUnit unit1, Archer unit2)
        {
            while (unit1.Health > 0 & unit2.Health > 0)
            {
                var rnd = new Random();
                unit2.RangeAttack(unit1, rnd);
                unit1.Info();
                unit1.MeeleeAttack(unit2, rnd);
                unit2.Info();
            }
        }
    }
}

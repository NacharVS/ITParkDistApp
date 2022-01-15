using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        public static void Fight(BattleUnit unit1, BattleUnit unit2, Random rnd)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                if (unit2.Health > 0)
                {
                    unit1.Health -= unit2.Attack(rnd) - unit1.Armor;
                    unit1.Info();
                }

                if (unit1.Health >0)
                {
                    unit2.Health -= unit1.Attack(rnd) - unit2.Armor;
                    unit1.Info();
                }
            }

            if (unit2.Health <= 0)
            {
                Console.WriteLine($"Won {unit1.Name}!");
            }
            else if (unit1.Health <= 0)
            {
                Console.WriteLine($"Won {unit2.Name}!");
            }
        }

        public static void BuildingAttack(Buildings building, Shooter shooter, Random rnd)
        {
            while (building.Wall > 0 && shooter.Health > 0)
            {
                building.Health -= shooter.DistanceAttack(rnd) - building.Armor;

                building.Info();
                shooter.Info();
            }
        }

        public static void MovingAttack(Shooter shooter, BattleUnit unit, Random rnd)
        {
            while (shooter.Health > 0 && unit.Health > 0)
            {
                unit.Health -= shooter.DistanceAttack(rnd) - unit.Armor - unit.Speed;

                unit.Info();
                shooter.Info();
            }
        }
    }
}

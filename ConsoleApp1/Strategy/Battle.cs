using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        
        public static void Fight(BattleUnit unit1, BattleUnit unit2)
        {
            Random rnd = new Random();

            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health = unit1.Health - unit2.Attack(rnd);
                unit2.Health = unit2.Health - unit1.Attack(rnd);
                unit1.Info();
                
                unit2.Info();
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

        public static void Fight(Buildings building, Shooter shooter, Random rnd)
        {
            while (building.Wall > 0 && shooter.Health > 0)
            {
                building.Wall -= shooter.DistanceAttack(rnd);
                
                building.Info();
                shooter.Info();
            }
        }

        public static void Fight(Shooter shooter, BattleUnit unit, Random rnd)
        {
            while (shooter.Health > 0 && unit.Health > 0)
            {
                unit.Health -= shooter.DistanceAttack(rnd);

                unit.Info();
                shooter.Info();
            }
        }

        public static void Fight(Buildings building, BattleUnit unit, Random rnd)
        {
            if (unit.IsCatapult)
            {
                while (building.Health > 0)
                {
                    if (building.Wall > 0)
                    {
                        building.Wall -= unit.MeleeAttack(rnd);                    
                        building.Info();
                        unit.Info();
                    }
                    else
                    {
                        building.Health -= unit.MeleeAttack(rnd);                 
                        building.Info();
                        unit.Info();
                    }
                }
            }
            else
            {
                Console.WriteLine($"{unit.Name} can not attack Building");
            }
        }

        public static void Fight(ArcherTower archerTower, BattleUnit unit, Random rnd)
        {
            while (archerTower.Wall > 0 && unit.Health > 0)
            {
                if (archerTower.CanAttack)
                {
                    archerTower.Wall -= unit.MeleeAttack(rnd);
                    unit.Health -= archerTower.Attack(rnd);

                    unit.Info();
                    archerTower.Info();
                }

                else
                {
                    archerTower.Wall = archerTower.Health - unit.MeleeAttack(rnd);               
                    
                    archerTower.Info();
                    unit.Info();
                }
            }
        }
    }
}

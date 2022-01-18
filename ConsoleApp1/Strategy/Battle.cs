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
            while (unit1.health > 0 && unit2.health > 0)
            {
                unit1.health -= unit2.MleeAttack(new Random())- unit1.armor;
                unit2.health -= unit1.MleeAttack(new Random())- unit2.armor;
                unit1.Info();
                unit2.Info();
            }
        }
        public static void Fight(Archer archer, BattleUnit unit2)
        {
            while (archer.health > 0 && unit2.health > 0)
            {
                archer.health -= unit2.MleeAttack(new Random())-archer.armor; 
                unit2.health -= archer.RangeAttack(new Random())-unit2.armor;
                archer.Info();
                unit2.Info();
            }
        }

        //public static void Fight(Buildings building, BattleUnit unit2)
        //{
        //    if (unit2.IsCatapult)
        //    {
        //        while (building.health > 0)
        //        {
        //            if (building.Wall > 0)
        //            {
        //                building.Wall = building.Wall - unit2.MleeAttack(new Random()); // 5                    
        //                building.Info();
        //                unit2.Info();
        //            }
        //            else
        //            {
        //                building.health = building.health - unit2.MleeAttack(new Random()); // 5                    
        //                building.Info();
        //                unit2.Info();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{unit2.name} can not attack Building");
        //    }
        //}
        //public static void Fight(ArcherTower tower, BattleUnit unit2)
        //{
        //    if (tower.CanAttack)
        //    {
        //        //while (tower.Health > 0 && unit2.Health > 0)
        //        //{
        //        tower.Health = tower.Health - unit2.MleeAttack(new Random()); // 5
        //        unit2.Health -= tower.Attack(new Random());
        //        tower.Info();
        //        unit2.Info();
        //        //}
        //    }
        //    else
        //    {
        //        tower.Health = tower.Health - unit2.MleeAttack(new Random()); // 5               
        //        tower.Info();
        //        unit2.Info();
        //    }



        
    }
}

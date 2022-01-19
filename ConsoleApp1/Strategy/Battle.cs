using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        public static void Fight(BattleUnit unit1, Buildings building, Random rnd)
        {
            //Console.WriteLine($"DMG reduction {building.name}(ARM:{building.armor}): {building.DamageReduction()}");
            Console.WriteLine($"Fight begin between {unit1.name}({unit1.Health}) and {building.name}({building.Health}/{building.Wall})!");
            double atck2 = 0;
            while (building.Health > 0)
            {
                
                var atck = unit1.BuildingAttack(rnd) * building.DamageReduction(); ;
                if (building.Wall > 0 & atck <= building.Wall)
                {
                    building.Wall -= atck;
                    atck2 = atck - building.Wall;
                }
                else if (atck > building.Wall & atck2 != 0)
                {
                    building.Wall = 0;
                    building.Health -= atck2;
                    atck2 = 0;
                }
                else
                    building.Health -= atck;
                building.Info();
            }
        }
        public static void Fight(BattleUnit unit1, BattleUnit unit2, Random rnd)
        {
            //Console.WriteLine($"DMG reduction {unit1.name}(ARM:{unit1.armor}): {unit1.DamageReduction()}\nDMG reduction {unit2.name}(ARM:{unit2.armor}): {unit2.DamageReduction()}");
            Console.WriteLine($"Fight begin between {unit1.name}({unit1.Health}) and {unit2.name}({unit2.Health})!");
            while (unit1.Health > 0 & unit2.Health > 0)
            {
                unit1.Health -= unit2.MeeleeAttack(rnd) * unit1.DamageReduction();
                unit2.Health -= unit1.MeeleeAttack(rnd) * unit2.DamageReduction();
                unit1.Info();
                unit2.Info();
            }
        }
        //public static void Fight(Archer archer, BattleUnit unit2)
        //{
        //    Console.WriteLine($"Damage reduction {archer.name}(armor:{archer.armor}): {archer.damageReduction}");
        //    Console.WriteLine($"Damage reduction {unit2.name}(armor:{unit2.armor}): {unit2.damageReduction}");
        //    while (archer.Health > 0 & unit2.Health > 0)
        //    {
        //        archer.Health -= unit2.MleeAttack(new Random()) * (100 - archer.damageReduction) / 100;
        //        unit2.Health -= archer.RangeAttack(new Random()) * (100 - unit2.damageReduction) / 100;
        //        archer.Info();
        //        unit2.Info();
        //    }
        //}
        //public static void Fight(Catapult catapult, Buildings building)
        //{
        //    Console.WriteLine($"Damage reduction {building.name}(armor:{building.armor}): {building.damageReduction}");

        //    while (building.Health > 0)
        //    {
        //        if (building.Wall>0)
        //        {
        //            building.Wall-= catapult.BuildingAttack(new Random()) * (100 - building.damageReduction) / 100;
        //            building.Info();
        //        }
        //        else
        //        {
        //            building.Health -= catapult.BuildingAttack(new Random()) * (100 - building.damageReduction) / 100;
        //            building.Info();
        //        }
        //    }
        //}
        //ОБРАЗЕЦ!

        //public static void Fight(ArcherTower unit1, int archAmount, Unit unit2)
        //{
        //    Console.WriteLine($"Damage reduction {unit2.name}(armor:{unit2.armor}): {unit2.damageReduction}");
        //    while (unit2.Health > 0)
        //    {
        //        var rnd = new Random();

        //        unit2.Health -= (unit1.Attack(rnd, archAmount) * (100 - unit2.damageReduction) / 100) * (1 + archAmount / 5);
        //        unit2.Info();
        //    }
        //}
        //public static void Fight(ArcherTower tower, BattleUnit unit2)
        //{
        //    if (tower.CanAttack)
        //    {
        //        while (tower.Health > 0)
        //            tower.Health -= unit2.MleeAttack(new Random()) * (100 - tower.damageReduction) / 100;
        //        unit2.Health -= tower.Attack(new Random()) * (100 - unit2.damageReduction) / 100;
        //        tower.Info();
        //        unit2.Info();
        //    }
        //}
    }
}

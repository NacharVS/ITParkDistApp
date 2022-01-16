﻿using System;
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
            Console.WriteLine($"Damage reduction {unit1.name}(armor:{unit1.armor}): {unit1.damageReduction}");
            Console.WriteLine($"Damage reduction {unit2.name}(armor:{unit2.armor}): {unit2.damageReduction}");
            while (unit1.Health > 0 & unit2.Health > 0)
            {
                unit1.Health -= unit2.MleeAttack(new Random()) * (100 - unit1.damageReduction) / 100;
                unit2.Health -= unit1.MleeAttack(new Random()) * (100 - unit2.damageReduction) / 100;
                unit1.Info();
                unit2.Info();
            }
        }
        public static void Fight(Archer archer, BattleUnit unit2)
        {
            Console.WriteLine($"Damage reduction {archer.name}(armor:{archer.armor}): {archer.damageReduction}");
            Console.WriteLine($"Damage reduction {unit2.name}(armor:{unit2.armor}): {unit2.damageReduction}");
            while (archer.Health > 0 & unit2.Health > 0)
            {
                archer.Health -= unit2.MleeAttack(new Random()) * (100 - archer.damageReduction) / 100;
                unit2.Health -= archer.RangeAttack(new Random()) * (100 - unit2.damageReduction) / 100;
                archer.Info();
                unit2.Info();
            }
        }
        public static void Fight(Catapult catapult, Buildings building)
        {
            Console.WriteLine($"Damage reduction {building.name}(armor:{building.armor}): {building.damageReduction}");
            while (building.Health > 0)
            {
                if (building.Wall>0)
                {
                    building.Wall-= catapult.BuildingAttack(new Random()) * (100 - building.damageReduction) / 100;
                    building.Info();
                }
                else
                {
                    building.Health -= catapult.BuildingAttack(new Random()) * (100 - building.damageReduction) / 100;
                    building.Info();
                }
            }
        }
        public static void Fight(BattleUnit unit1, Buildings building)
        {
            Console.WriteLine($"Damage reduction {building.name}(armor:{building.armor}): {building.damageReduction}");
            while (building.Health > 0)
            {
                building.Health -= unit1.Attack(new Random()) * (100 - building.damageReduction) / 100;
                building.Info();
            }
        }
        public static void Fight(ArcherTower unit1, int archAmount, Unit unit2)
        {
            Console.WriteLine($"Damage reduction {unit2.name}(armor:{unit2.armor}): {unit2.damageReduction}");
            while (unit2.Health > 0)
            {
                var rnd = new Random();

                unit2.Health -= (unit1.Attack(rnd, archAmount) * (100 - unit2.damageReduction) / 100) * (1 + archAmount / 5);
                unit2.Info();
            }
        }
        public static void Fight(ArcherTower tower, BattleUnit unit2)
        {
            if (tower.CanAttack)
            {
                while (tower.Health>0)
                tower.Health -= unit2.MleeAttack(new Random()) * (100 - tower.damageReduction) / 100;
                unit2.Health -= tower.Attack(new Random()) * (100 - unit2.damageReduction) / 100;
                tower.Info();
                unit2.Info();
            }
        }
    }
}

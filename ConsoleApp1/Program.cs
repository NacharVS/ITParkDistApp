using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Peasant peasant1 = new Peasant("Oleg");
            Peasant peasant2 = new Peasant("Ivan");
            Archer archer = new Archer("Legolas");
            Healer healer = new Healer("Witchdoctor");
            Hospital hospital = new Hospital("First aid tent");
            Soldier soldier = new Soldier("Swordsman");
            WathingTower wathingTower = new WathingTower("ShootingTower");
            Console.WriteLine();
            peasant1.Info();
            soldier.Info();
            wathingTower.Info();
            Console.WriteLine();
            Console.WriteLine("Step 1");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine("Step 2");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine();
            Console.WriteLine("Step 3");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine();
            Console.WriteLine("Step 4");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine();
            Console.WriteLine("Step 5");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine();
            Console.WriteLine("Step 6");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);;
            Console.WriteLine();
            Console.WriteLine("Step 7");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Step 7");
            archer.RangeAttack(peasant1, rnd);
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            Console.WriteLine();
            




            // 1. Добавить методы лечения юнитов для класса Healer
            // 2. Добавить методы починки зданий для класса Peasant
            // 3. Добавить методы лечения юнитов для класса hospital

        }



    }
}
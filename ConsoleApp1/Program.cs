﻿using ConsoleApp1.Strategy;
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
            Shaman jinn = new Shaman("Jinn");
            Console.WriteLine();
            archer.Info();
            peasant1.Info();
            soldier.Info();
            wathingTower.Info();
            Console.WriteLine();
            Console.WriteLine("Step 1");
            Battle.Fight(archer, soldier);
            jinn.BoostHealth(soldier);
            
            healer.HealingUnit(peasant1);
            soldier.CrushinAttack(wathingTower, rnd);
            wathingTower.TowerAttack(soldier);
            peasant2.repairsBuilding(wathingTower);
            hospital.HospitalHealing(soldier);
            Console.WriteLine();
            archer.Info();
            peasant1.Info();
            soldier.Info();
            wathingTower.Info();
            Console.WriteLine();
            //Console.WriteLine("Step 2");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //Console.WriteLine();
            //Console.WriteLine("Step 3");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //Console.WriteLine();
            //Console.WriteLine("Step 4");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //Console.WriteLine();
            //Console.WriteLine("Step 5");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //Console.WriteLine();
            //Console.WriteLine("Step 6");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);;
            //Console.WriteLine();
            //Console.WriteLine("Step 7");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Step 7");
            //archer.RangeAttack(rnd);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //Console.WriteLine();
            
        }



    }
}
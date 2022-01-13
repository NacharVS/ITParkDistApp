using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ConsoleApp1.Strategy;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Peasant peasant1 = new Peasant("Ivan");
            WatchingTower tower = new WatchingTower();
            BattleUnit soldier = new BattleUnit("Rodion", 200, 10, "Warior", 5, 3, 7);
            Random rnd = new Random();
            //soldier.MeeleeAttack(peasant1, rnd);
            //peasant1.Move();
            //peasant1.Work();
            //tower.Observe();
            //soldier.Upgrade();
            //peasant1.Move();
            //soldier.MeeleeAttack(peasant1, rnd);
            //peasant1.Move();
            //soldier.MeeleeAttack(peasant1, rnd);
            //soldier.MeeleeAttack(peasant1, rnd);
            //soldier.MeeleeAttack(peasant1, rnd);
            //soldier.MeeleeAttack(peasant1, rnd);
            //soldier.MeeleeAttack(peasant1, rnd);
            //peasant1.Move();

            Archer archer = new Archer("Legolas");
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            Healer healer = new Healer("Doctor", 80, 1, "Healer", 6, 7, 15,200);
            healer.UnitHeal(healer,peasant1, rnd);
            peasant1.Info();
            healer.UnitHeal(healer, peasant1, rnd);
            peasant1.Info();
            healer.UnitHeal(healer, peasant1, rnd);
            peasant1.Info();
            healer.UnitHeal(healer, peasant1, rnd);
            peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            Buildings buildings = new Buildings("Castle", 2000, 15);
            soldier.MeeleeAttack(buildings, rnd);
            buildings.Info();
            soldier.MeeleeAttack(buildings, rnd);
            buildings.Info();
            soldier.MeeleeAttack(buildings, rnd);
            buildings.Info();
            peasant1.BuildingsRepair(buildings, rnd);
            buildings.Info();
            soldier.MeeleeAttack(peasant1, rnd);
            peasant1.Info();
            soldier.MeeleeAttack(peasant1, rnd);
            peasant1.Info();
            soldier.MeeleeAttack(peasant1, rnd);
            peasant1.Info();
            Hospital hospital = new Hospital("Holly Well", 800, 10, 1000, 20, 30);
            hospital.UnitHeal(hospital, peasant1, rnd);
            peasant1.Info();
            //ДЗ
            //HEALER
            // 1.Добавить методы лечения юнитов для класса Healer
            // +порог лечения, ресурс лечения (мана), кол-во лечения
            // 2.добавить метод починки зданий для классов Peasant
            // 3. Добавить методы лечения юнитов для класса hospital
        }
    }
}

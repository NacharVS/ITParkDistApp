using ConsoleApp1.InterfacesLab;
using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Machinegun machinegun = new Machinegun();
            Shotgun shotgun = new Shotgun();
            Pistol pistol = new Pistol();
            Knife knife = new Knife();
            IWeapon qq = machinegun;

            Gunslinger Bob = new Gunslinger();
            Bob.PickUpItem(machinegun);
            Bob.PickUpItem(shotgun);
            Bob.PickUpItem(pistol);
            Bob.FireFromAllWeapons();
            Mechanic Igor = new Mechanic();
            Igor.UpgradeDamage(shotgun);
            Bob.FireFromAllWeapons();




            //Archer archer = new Archer(new ShortBow(10), new IronDagger());
            //Warrior unit1 = new Warrior();
            //unit1.weapon = new StoneAxe();
            //unit1.Attack(unit1.weapon.Damage);
            //unit1.weapon = new ShortSword();
            //unit1.Attack(unit1.weapon.Damage);
            //unit1.weapon = new IronDagger();
            //unit1.Attack(unit1.weapon.Damage);



            //Random rnd = new Random();
            //Peasant peasant1 = new Peasant("Oleg");
            //Peasant peasant2 = new Peasant("Ivan");
            //Archer archer = new Archer("Legolas");
            //Healer healer = new Healer("Witchdoctor");
            //Hospital hospital = new Hospital("First aid tent");
            //Soldier soldier = new Soldier("Swordsman");
            //WathingTower wathingTower = new WathingTower("ShootingTower");
            //Shaman jinn = new Shaman("Jinn");
            //Console.WriteLine();
            //archer.Info();
            //peasant1.Info();
            //soldier.Info();
            //wathingTower.Info();
            //Console.WriteLine();
            //Console.WriteLine("Step 1");
            //Battle.Fight(archer, soldier);
            //healer.HealingUnit(peasant1);
            //soldier.CrushinAttack(wathingTower, rnd);
            //wathingTower.TowerAttack(soldier);
            //peasant2.repairsBuilding(wathingTower);
            //hospital.HospitalHealing(soldier);
            //jinn.BoostHealth(soldier);
            //jinn.Frenzy(soldier);
            //jinn.StoneSkin(soldier);
            //jinn.BoostHealth(soldier);
            //jinn.Frenzy(soldier);
            //jinn.StoneSkin(soldier);
            //Console.WriteLine();
            //archer.Info();
            //peasant1.Info();
            //soldier.Info();
            //wathingTower.Info();
            //Console.WriteLine();
            //Console.WriteLine("Step 2");       
        }



    }
}
using ConsoleApp1.InterfacesLab;
using ConsoleApp1.StategyInterfaces;
using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) 
        {
            var machinegun = Mechanic.MakeMachinegun(10, 30);
            //Shotgun shotgun = new Shotgun();
            //Pistol pistol = new Pistol();
            //Knife knife = new Knife();
           
            Gunslinger Bob = new Gunslinger();

            Mechanic Igor = new Mechanic();

            Bob.Fire(machinegun);
            machinegun.ShowInfo();
            Bob.MultiFire(machinegun);
            Bob.MultiFire(machinegun);
            Bob.MultiFire(machinegun);
            Bob.MultiFire(machinegun);
            Bob.MultiFire(machinegun);
            machinegun.ShowInfo();
            Igor.Repair(machinegun);
            machinegun.ShowInfo();
            Igor.UpgradeDamage(machinegun);
            Bob.MultiFire(machinegun);
            Bob.Reload(machinegun);





            //Random rnd = new Random();

            //Peasant peasant1 = new Peasant("Ivan");
            //Archer archer = new Archer("Legolas");
            //Healer healer = new Healer("Gendalf", 20);
            //var war1 = new Warrior("Bob");          
            //Warrior war2 = new Warrior("John");

            //war1.DamageEvent += (string name, double health, double damagecount) =>
            //{
            //    Console.WriteLine($"{name} with {health} HP. Injured by {damagecount}");
            //}; //реализация анонимного метода через лямбда-выражение

            //war1.MaxHealthEvent += (string name, double diff) =>
            //{
            //    Console.WriteLine($"Health of {name} increased by {diff}");
            //};

            //war1.HealEvent += Heal;
            //var wTower = new WathingTower();
            //Catapult catapult = new Catapult();
            //var archerTower = new ArcherTower();
            //Shaman shaman = new Shaman("Peter");
            //shaman.HealhBuff(war1);
            //healer.SalvationBuff(war1);
            //shaman.FrenzyBuff(war2);
            //Battle.Fight(war1, war2);


            // Health = Health + 5;

        }


        //public static void Damage(string name, double health, double damagecount)
        //{
        //    Console.WriteLine($"{name} with {health} HP. Injured by {damagecount}");
        //}

        public static void Heal(string name, double health, double healcount)
        {
            Console.WriteLine($"{name} with {health} HP. Healed by {Math.Abs(healcount)}");
        }

        public static void HealthBuffMessage(string name, double diff)
        {
            Console.WriteLine($"Health of {name} increased by {diff}");
        }


    }
}

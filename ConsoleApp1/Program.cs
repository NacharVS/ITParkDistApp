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

            Peasant peasant1 = new Peasant("Ivan");
            Archer archer = new Archer("Legolas");
            Healer healer = new Healer("Gendalf", 20);
            Warrior war1 = new Warrior("Bob");          
            Warrior war2 = new Warrior("John");
            war1.DamageEvent += Damage;
            war1.HealEvent += Heal;
            WathingTower wTower = new WathingTower();
            Catapult catapult = new Catapult();
            ArcherTower archerTower = new ArcherTower();
            Shaman shaman = new Shaman("Peter");
            healer.SalvationBuff(war1);
            shaman.FrenzyBuff(war2);
            Battle.Fight(war1, war2);
            

            // Health = Health + 5;

        }


        public static void Damage(string name, double health, double damagecount)
        {
            Console.WriteLine($"{name} with {health} HP. Injured by {damagecount}");
        }

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

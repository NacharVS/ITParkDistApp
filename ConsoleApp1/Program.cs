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
            WathingTower wTower = new WathingTower();
            Catapult catapult = new Catapult();
            ArcherTower archerTower = new ArcherTower();
            Shaman shaman = new Shaman("Peter");
            shaman.HealhBuff(war1);
            war1.Info();
            healer.Heal(war1);
            war1.Info();


        }



    }
}

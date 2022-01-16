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
            catapult.Info();
            //Warrior war2 = new Warrior("John");
            //Battle.Fight(archer, war2);
            //healer.Heal(war2);
            //healer.Heal(war2);
            //healer.Heal(war2);
            //healer.Heal(war2);
            //war2.Info();
            ArcherTower archerTower = new ArcherTower();

            //for (int i = 0; i < 1; i++)
            //{
            //    archerTower.LoadArchers(archer);
            //}

            Battle.Fight(war1, war2);

            //Console.Read();

            // Реализовать новый юнит Shaman которыйможет накидывать ряд усилений. 
            // 1. BoostHealth - Увеличивает максимальное здоровье на 50%
            // 2. Frenzy - Увеличивает показатель урона на 1,5 и снижает показатель защиты 0.5
            // 3. StoneSkin - увеличивает показатель защиты в 2 раза, и снижает скорость в 2 раза
            // *все усиления могут накладывать только 1 раз на 1 юнита (не стакаються)
        }



    }
}

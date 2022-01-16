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
            WathingTower wTower = new WathingTower();
            //Warrior war2 = new Warrior("John");
            //Battle.Fight(archer, war2);
            //healer.Heal(war2);
            //healer.Heal(war2);
            //healer.Heal(war2);
            //healer.Heal(war2);
            //war2.Info();
            ArcherTower archerTower = new ArcherTower();
            Console.WriteLine(wTower.ToString());
            //for (int i = 0; i < 1; i++)
            //{
            //    archerTower.LoadArchers(archer);
            //}

            //Battle.Fight(wTower, war1);

            //Console.Read();

            //1. Доработать методы боя с учетом показателя Armor. 
            //2. Реализовать атаку катапульты по зданиям.
            //3.* Реализовать атаку катапульты по движущимся юнитам
            //4.** Доработать ArcherTower. 
            //В башне может быть до 5 лучников, чем больше лучников - тем больше урон. 
            //Если лучников нет, башня не атакует, если емть хотя бы 1 то атакует.
        }



    }
}

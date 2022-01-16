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
            var rnd = new Random();
            //Peasant peasant1 = new Peasant("Ivan");
            var archer = new Archer("Rifleman", 535,0);
            var healer = new Healer("Priest",290,200,0, 25);
            var war1 = new Warrior("Footman", 420, 2);
            var war2 = new Warrior("Knight", 835,5);
            //Battle.Fight(archer, war2);
            //healer.Heal(war2);
            //war2.Info();
            //healer.Heal(war2);
            //war2.Info();
            //healer.Heal(war2);
            //war2.Info();
            //healer.Heal(war2);
            //war2.Info();
            var catapult = new Catapult("Catapult",700,40,60);
            var building= new Buildings("Town Hall",1500,5);
            Battle.Fight(catapult, building);
            Battle.Fight(catapult, war1);
            //Battle.Fight(catapult, war2);
            //Battle.Fight(catapult, archer);
            //Battle.Fight(catapult, healer);
            //ArcherTower archerTower1 = new ArcherTower("Guard Tower",500,5, 20, 30);
            //Console.Write("How many archers in a ArchTower?(0-5):");
            //int archAmount = Convert.ToInt32(Console.ReadLine());
            //Battle.Fight(archerTower1, archAmount, catapult);
            //healer.Heal(war1);
            //war1.Info();
            //healer.Heal(catapult);
            //catapult.Info();
            //healer.Heal(war1);
            //war1.Info();
            //healer.Heal(catapult);
            //catapult.Info();
            //Battle.Fight(catapult, war1);
            //13.01.2022 Инкапсуляция свойств. Лекция 9
            //var std1 = new Student();
            //std1.Age = 20;
            //Console.WriteLine(std1.Age);
            //Lection 16.01.22
            //for (int i = 0; i < 5; i++)
            //{
            //    archerTower1.LoadArchers(archer);
            //}
            //Battle.Fight(archerTower1, war1);
            Console.Read();
            //ДЗ 13.01.2022
            //1) доработать методы боя с учетом показателя брони (формулу на свое усмотрение).
            //2) нового юнита добавим Catapult - ломает здания. Реализовать атаку.
            //3*) реализовать атаку катапультой по МуваблЮнит(движущимся) и зданиям
            //4**)Сделать АрчерТовер, наследуется от ВатчингТовер. Доработать, чтобы в башне могло быть до 5 лучников - 
            //-чем больше лучником - тем больше урон. Без лучников не атакует.

            //новый юнит - накидывает бафы на юнитов
            //1.Boost.Health - увеличивает здовроьве на 50%
            //2.Frenzy - увеличивает показатель урона на 1.5 и снижает защиту на 0,5
            //3.StoneSkin - увеличивает защиту в 2 раза и снижает скорость в 2 раза
            //*все усиления могут накладываться 1 раз
        }
    }
}

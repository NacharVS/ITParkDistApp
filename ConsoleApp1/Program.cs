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
            Random rnd = new Random();

            //Peasant peasant1 = new Peasant("Ivan");
            //Archer archer = new Archer("Legolas");
            //Healer healer = new Healer("Gendalf", 20);
            Warrior war1 = new Warrior("Bob");
            //Warrior war2 = new Warrior("John");
            //Battle.Fight(archer, war2);
            //healer.Heal(war2);
            //war2.Info();
            //healer.Heal(war2);
            //war2.Info();
            //healer.Heal(war2);
            //war2.Info();
            //healer.Heal(war2);
            //war2.Info();
            Catapult catapult = new Catapult("Catapult");
            Buildings building = new Buildings("Castle", 1100, 15);
            Battle.Fight(catapult, building);
            ArcherTower archerTower1 = new ArcherTower("ArcherTower1", 200,8, 10, 20);
            Console.Write("How many archers in a ArchTower?(0-5):");
            int archAmount = Convert.ToInt32(Console.ReadLine());
            Battle.Fight(archerTower1, archAmount, catapult);

            //13.01.2022 Инкапсуляция свойств. Лекция 9
            //var std1 = new Student();
            //std1.Age = 20;
            //Console.WriteLine(std1.Age);

            //ДЗ 13.01.2022
            //1) доработать методы боя с учетом показателя брони (формулу на свое усмотрение).
            //2) нового юнита добавим Catapult - ломает здания. Реализовать атаку.
            //3*) реализовать атаку катапультой по МуваблЮнит(движущимся) и зданиям
            //4**)Сделать АрчерТовер, наследуется от ВатчингТовер. Доработать, чтобы в башне могло быть до 5 лучников - 
            //-чем больше лучником - тем больше урон. Без лучников не атакует.
        }
    }
}

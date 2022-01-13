using System;
using System.Collections.Generic;
using System.Threading;
using ConsoleApp1.Mylib;
using ConsoleApp1.Strategy;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Warrior warrior1 = new Warrior("Bob1");
            Warrior warrior2 = new Warrior("Bob2");
            Battle.Fight(warrior1, warrior2, rnd);

            //Peasant peasant = new Peasant("Ivan");

            //Archer archer = new Archer("Legolas");



            //healer.Treatment(peasant, rnd);
            //peasant.Info();



            // 1. Доработать методы боя с учётом Armor;
            // 2. Доработать методы лечения;
            // 3. Добавить новый unit Catapult, может ломать здания и других юнитов;
            // 4. Атака катапультой по зданию и по движущимся юнитам;
            // 5. Добавить Unit ArcherTower наследуется от WathingTower, в башне может быть до 5-и лучников; без лучников не атакует.

        }


    }
}

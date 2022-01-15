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

            WathingTower wathingTower = new WathingTower("WathingTower");
            Catapult catapult = new Catapult();

            ArcherTower archerTower = new ArcherTower("ArcherTower", 1);

            Healer healer1 = new Healer("Gendalf");

            Warrior warrior1 = new Warrior("Bob1");
            Warrior warrior2 = new Warrior("Bob2");

            Archer archer1 = new Archer("Legolaz1");
            Archer archer2 = new Archer("Legolaz2");

            //Battle.Fight(warrior1, warrior2, rnd);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(warrior2, rnd);

            //Battle.Fight(archer1, archer2, rnd);
            //healer1.Treatment(archer1, rnd);
            //healer1.Treatment(archer2, rnd);

            //Battle.Fight(archer1, warrior1, rnd);
            //healer1.Treatment(archer1, rnd);
            //healer1.Treatment(warrior1, rnd);

            //Battle.Fight(archer2, warrior2, rnd);
            //healer1.Treatment(archer2, rnd);
            //healer1.Treatment(warrior2, rnd);

            //Battle.BuildingAttack(wathingTower, catapult, rnd);
            //healer1.Treatment(archer1, rnd);
            //healer1.Treatment(warrior1, rnd);

            //Battle.Fight(warrior1, catapult, rnd);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(catapult, rnd);

            //Battle.MovingAttack(catapult, warrior1, rnd);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(catapult, rnd);

            Battle.ArcherTowerAttack(archerTower, warrior1, rnd);
            //healer1.Treatment(warrior1, rnd);
            //healer1.Treatment(catapult, rnd);




            // 1. Доработать методы боя с учётом Armor;
            // 2. Доработать методы лечения;
            // 3. Добавить новый unit Catapult, может ломать здания и других юнитов;
            // 4. Атака катапультой по зданию и по движущимся юнитам;
            // 5. Добавить Unit ArcherTower наследуется от WathingTower, в башне может быть до 5-и лучников; без лучников не атакует.

        }


    }
}

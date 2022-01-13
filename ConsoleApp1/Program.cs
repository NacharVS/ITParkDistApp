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

            

            // 1. Добавить методы лечения юнитов для класса Healer
            // 2. Добавить методы починки зданий для класса Peasant
            // 3. Добавить методы лечения юнитов для класса hospital
        }


    }
}

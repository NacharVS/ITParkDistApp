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

            Peasant peasant = new Peasant("Ivan");

            Archer archer = new Archer("Legolas");

            Healer healer = new Healer("Doctor");

            //Hospital hospital = new Hospital();

            archer.RangeAttack(peasant, rnd);
            
            archer.RangeAttack(peasant, rnd);
            
            archer.RangeAttack(peasant, rnd);
            
            archer.RangeAttack(peasant, rnd);
            
            archer.RangeAttack(peasant, rnd);
            
            //archer.RangeAttack(peasant, rnd);
            //peasant.Info();
            //archer.RangeAttack(peasant, rnd);
            //peasant.Info();

            healer.Treatment(peasant, rnd);
            
            //healer.Treatment(peasant, rnd);
            //peasant.Info();

            

            // 1. Добавить методы лечения юнитов для класса Healer
            // 2. Добавить методы починки зданий для класса Peasant
            // 3. Добавить методы лечения юнитов для класса hospital
        }


    }
}

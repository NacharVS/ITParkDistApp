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
            Peasant peasant1 = new Peasant("Ivan");
            Archer archer = new Archer("Legolas");
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();


            // 1. Добавить методы лечения юнитов для класса Healer
            // 2. Добавить методы починки зданий для класса Peasant
            // 3. Добавить методы лечения юнитов для класса hospital
        }


    }
}

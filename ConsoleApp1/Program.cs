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
            archer.RangeAttack(healer, rnd);
            healer.Info();
            archer.RangeAttack(healer, rnd);
            healer.Info();
            archer.RangeAttack(healer, rnd);
            healer.Info();
            healer.Heal(healer);
            healer.Info();


            // 1. Добавить методы лечения юнитов для класса Healer
            // 2. Добавить методы починки зданий для класса Peasant
            // 3. Добавить методы лечения юнитов для класса hospital

        }



    }
}

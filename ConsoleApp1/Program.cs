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
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();

        }
 


    }
}

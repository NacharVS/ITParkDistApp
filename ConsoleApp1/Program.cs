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
            Soldier soldier = new Soldier("Rodion");
            soldier.Upgrade();
            peasant1.Move();
            soldier.AttackPeasant(peasant1, rnd);
            peasant1.Move();
            soldier.AttackPeasant(peasant1, rnd);
            soldier.AttackPeasant(peasant1, rnd);
            soldier.AttackPeasant(peasant1, rnd);
            soldier.AttackPeasant(peasant1, rnd);
            soldier.AttackPeasant(peasant1, rnd);
            peasant1.Move();

        }
 


    }
}

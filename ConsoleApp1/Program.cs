using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Peasant peasant1 = new Peasant("Ivan");
            WathingTower tower = new WathingTower();
            peasant1.Work();
            tower.Observe();
            
        }
 


    }
}

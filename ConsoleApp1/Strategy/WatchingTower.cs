﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    class WathingTower : Buildings
    {
        public WathingTower() : base("Tower", 100, 20)
        {
        }

        public void Observe()
        {
            Console.WriteLine($"{name} is Observing. Statement {Wall}, {Health}, {Armor}");
        }
        
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    internal interface IMovableUnit
    {
        double Health { get; set; }
        int Armor { get; set; }
        int MovingSpeed { get; set; }
        int Grade { get; set; }
        int Expirience { get; set; }
        void Move();
        void LevelUp();
        event Action CreateEvent;
        event Action DeathEvent;
    }
}

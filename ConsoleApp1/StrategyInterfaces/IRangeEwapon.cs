﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    interface IRangeEwapon 
    {
       double RangeDamage { get; }
        bool IsEmpty { get; set; }
        void Shoot();
        
    }
}

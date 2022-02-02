using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    interface IRepairible 
    {
        int Durability { get; set; }

        void Repair();
    }
}

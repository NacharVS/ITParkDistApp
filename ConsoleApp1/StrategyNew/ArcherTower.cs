using ConsoleApp1.StrategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyNew
{
    internal class ArcherTower : IBattleUnit
    {
       public double Damage { get; set; }
    }
}

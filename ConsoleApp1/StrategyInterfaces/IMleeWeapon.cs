using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    interface IMleeWeapon
    {
        double Damage { get; set; }
        int AttackSpeed { get; set; }
    }
}
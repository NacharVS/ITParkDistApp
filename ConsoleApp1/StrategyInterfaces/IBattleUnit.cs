using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    internal class IBattleUnit
    {
        IWeapon weapon { get; set; }
        void Attack(double dmg);

    }
}

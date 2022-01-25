using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class Battle
    {
        public static void Fite(BattleUnit unit1, BattleUnit unit2)
        {
            while(unit1.health >0 || unit2.health > 0)
            {
                unit1.health -= unit2.MleeAttack(new Random());
                unit2.health -= unit1.MleeAttack(new Random());
                unit1.Info();
                unit2.Info();
            }
        }
    }
}

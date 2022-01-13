using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        public static void Fight(Warrior warrior1, Warrior warrior2, Random rnd)
        {
            while (warrior1.Health > 0 && warrior2.Health > 0)
            {
                warrior1.Health -= warrior2.MeleeAttack(rnd);
                warrior2.Health -= warrior1.MeleeAttack(rnd);
                warrior1.Info();
                warrior2.Info();
            }
        }
    }
}

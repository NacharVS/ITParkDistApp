using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        public static void Fight(BattleUnit unit1, BattleUnit unit2, Random rnd)
        {
            while (unit1.Health > 0 && unit2.Health > 0)
            {
                unit1.Health -= unit2.Attack(rnd)- unit1.Armor;
                unit2.Health -= unit1.Attack(rnd)- unit2.Armor;
                unit1.Info();
                unit2.Info();
            }
            if (unit2.Health <= 0)
            {
                Console.WriteLine($"Won {unit1.Name}!");
            }
            else if (unit1.Health <= 0)
            {
                Console.WriteLine($"Won {unit2.Name}!");
            }

        }
    }
}

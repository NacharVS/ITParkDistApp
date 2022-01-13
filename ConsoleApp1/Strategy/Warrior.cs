using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : BattleUnit
    {
        public Warrior(string name) : base(name, 80, 0, 5, 2, 8)
        {

        }

        public double MeleeAttack(Random rnd)
        {
            double currentDamage = rnd.Next(minDamage, maxDamage);
            return currentDamage;
        }
    }
}

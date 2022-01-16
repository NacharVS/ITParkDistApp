﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Battle
    {
        public static void Fight(BattleUnit unit1, BattleUnit unit2)
        {
            while(unit1.Health > 0 & unit2.Health > 0)
            {
                unit1.Health -= unit2.MleeAttack(new Random());
                unit2.Health -= unit1.MleeAttack(new Random());
                unit1.Info();
                unit2.Info();
            }
        }
        public static void Fight(Archer archer, BattleUnit unit2)
        {
            while (archer.Health > 0 & unit2.Health > 0)
            {
                archer.Health = archer.Health - unit2.MleeAttack(new Random()); // 5
                unit2.Health -= archer.RangeAttack(new Random());
                archer.Info();
                unit2.Info();
            }
        }
    }
}

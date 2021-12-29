using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : BattleUnit
    {
        private double _healing;
        private int _mana;

        public Healer(string name) : base(name, 45, 0, "witchdoctor", 7, 1, 2)
        {
            _mana = 20;
        }

        public void HealingUnit(Peasant peasant)
        {
            if (_mana > 0)
            {
                _healing = 0.1 * peasant.health;
                if ((0 < peasant.health) && (30 > peasant.health))
                {
                    _mana -= 10;
                    peasant.health += _healing;
                    Console.WriteLine($"{name} heals {peasant.name} by {_healing} hp.{name} has {_mana} mana");  
                }
                else
                if (peasant.health <= 0)
                {
                    Console.WriteLine($"{peasant.name} is death.");
                }
                else
                    if (peasant.health >= 30)
                {
                    Console.WriteLine($"{peasant.name} has max health.");
                }
            }
            else
                if(_mana<=0)
            {
                Console.WriteLine($"{name} don't have mana.");
            }
        }


    }
}

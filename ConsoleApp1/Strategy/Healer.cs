using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : MovableUnits
    {
        private double _healing;
        private int _mana;

        public Healer(string name) : base(name, 45, 0, "Witchdoctor", 7)
        {
            _mana = 20;
        }

        public void HealingUnit(MovableUnits unit)
        {
            if (_mana > 0)
            {
                _healing = 0.1 * unit.health;
                if ((0 < unit.health) && (_maxHealth > unit.health))
                {
                    _mana -= 10;
                    unit.health += _healing;
                    Console.WriteLine($"{name} heals {unit.name} by {_healing} hp.{name} has {_mana} mana");  
                }
                else
                if (unit.health <= 0)
                {
                    Console.WriteLine($"{unit.name} is death.");
                }
                else
                    if (unit.health >= unit._maxHealth)
                {
                    Console.WriteLine($"{unit.name} has max health.");
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

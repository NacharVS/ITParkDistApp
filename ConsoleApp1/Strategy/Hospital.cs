using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        private double _healing;
        private int _medicament;
        public Hospital(string name) : base(name, 35, 0 )
        {
            _medicament = 200;
        }
        public void HospitalHealing(MovableUnits unit)
        {
            if (_medicament > 0)
            {
                _healing = unit._maxHealth-unit.health;
                if ((0 < unit.health) && (unit.health < _maxHealth))
                {
                    _medicament -= 15;
                    unit.health = unit._maxHealth;
                    Console.WriteLine($"{name} heals {unit.name} by {_healing} hp.{name} has {_medicament} medicaments");
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
                else
                if (_medicament <= 0)
                {
                    Console.WriteLine($"{name} don't have medicament.");
                }
            }
        }
    }
}

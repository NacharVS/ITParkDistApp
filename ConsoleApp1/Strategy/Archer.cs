using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : Warrior
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _maxRangeDamage;

        public Archer(string name) : base(name, 45, 0, 7, 1, 2)
        {
            _arrows = 5;
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
        }

        public void RangeAttack(Citizen citizen, Random rnd)
        {
            if (_arrows > 0)
            {
                _arrows--;
                int currentDamage = rnd.Next(_minRangeDamage, _maxRangeDamage);
                Console.WriteLine($"{name} attack {citizen.name} with {currentDamage} points of damage");
                citizen.Wound(currentDamage);
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MeleeAttack(citizen, rnd);
            }
              
        }
    }
}

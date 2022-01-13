using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : BattleUnit
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _maxRangeDamage;

        public Archer(string name) : base(name, 45, 0, 7, 1, 2)
        {
            Arrows = 5;
            MinRangeDamage = 4;
            MaxRangeDamage = 12;
        }

        public void RangeAttack(MovableUnits unit, Random rnd)
        {
            if (Arrows > 0)
            {
                Arrows--;
                int currentDamage = rnd.Next(MinRangeDamage, MaxRangeDamage);
                Console.WriteLine($"{name} attack {unit.name} with {currentDamage} points of damage");
                unit.Wound(currentDamage);
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MeleeAttack(unit, rnd);
            }



        }
    }
}

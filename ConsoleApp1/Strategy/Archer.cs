﻿using System;

namespace ConsoleApp1.Strategy
{
    class Archer : BattleUnit
    {
        private int _arrows;
        private int _minRangeDamage;
        private int _maxRangeDamage;

        public Archer(string name) : base(name, 45, 0, "shooter", 7, 1, 2)
        {
            _arrows = 5;
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
        }

        public void RangeAttack(MovableUnits unit, Random rnd)
        {
            if (_arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
                unit.Health -= currentDamage;
                Console.WriteLine($"{name} attack {unit.name} with {currentDamage} points of damage");
                _arrows--;
                if (unit.Health <= 0)
                    unit.Termination();
            }
            else
            {
                Console.WriteLine("Arrows is empty");
                MeeleeAttack(unit, rnd);
            }

        }
    }
}

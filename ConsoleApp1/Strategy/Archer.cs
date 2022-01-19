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

        public Archer(string name) : base(name, 45, 0, "shooter", 7, 1, 2)
        {
            _arrows = 5;
            _minRangeDamage = 4;
            _maxRangeDamage = 12;
        }


        //public void RangeAttack(MovableUnits peasant, Random rnd)
        //{
        //    if (_arrows > 0)
        //    {
        //        double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
        //        peasant.health -= currentDamage;
        //        Console.WriteLine($"{name} attack {peasant.name} with {currentDamage} points of damage");
        //        _arrows--;
        //        if (peasant.health <= 0)
        //            peasant.Termination();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Arrows is empty");
        //        MleeAttack(peasant, rnd);
        //    }
        //}


        public double RangeAttack(Random rnd)
        {
            if (_arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
                return currentDamage;
            }
            else
            {
                return MleeAttack(rnd);
            }

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
                MleeAttack(unit, rnd);
            }

            }
        }
}

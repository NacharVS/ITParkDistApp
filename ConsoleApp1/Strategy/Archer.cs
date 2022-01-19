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

        public Archer(string name,int health, int armor ) : base(name, health, armor, "shooter", 7, 18, 24)
        {
            _arrows = 5;
            _minRangeDamage = 16;
            _maxRangeDamage = 26;
        }

        public double RangeAttack(Random rnd)
        {
            if (_arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
                return currentDamage;
            }
            else
            {
                return MeeleeAttack(rnd);
            }

        }
    }
}

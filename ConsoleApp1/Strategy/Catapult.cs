using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Catapult : BattleUnit
    {
        private int _minBuildingDamage;
        private int _maxBuildingDamage;
        internal override bool IsCatapult => true;
        public Catapult(string name) : base(name, 700, 2, "catapult", 3, 20, 30)
        {
            this._minBuildingDamage = 40;
            this._maxBuildingDamage = 60;
        }
        public double BuildingAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(_minBuildingDamage, _maxBuildingDamage));
            return currentDamage;
        }
    }
}

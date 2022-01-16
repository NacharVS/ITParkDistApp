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
        public Catapult(string name,int health, int minDamage, int maxDamage ) : base(name, health, 2, "catapult", 3, minDamage, maxDamage)
        {
            this._minBuildingDamage = minDamage*2;
            this._maxBuildingDamage = maxDamage*2;
        }
        public override double BuildingAttack(Random rnd)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(_minBuildingDamage, _maxBuildingDamage));
            Console.WriteLine($"{name} building attack with {currentDamage} damage");
            return currentDamage;
        }
        public override void Info()
        {
            Console.WriteLine($"Name: {name} HP: {Math.Round(Health)}");
        }
    }
}

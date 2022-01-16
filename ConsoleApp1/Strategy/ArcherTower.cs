using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class ArcherTower : Buildings
    {
        private int _minDamage;
        private int _maxDamage;
        public ArcherTower(string name, int health, int armor, int minDamage, int maxDamage) : base(name, health, armor)
        {
            this._minDamage = minDamage;
            this._maxDamage=maxDamage;
        }
       
        public double Attack(Random rnd, int archerAmount)
        {
            double currentDamage = Convert.ToDouble(rnd.Next(_minDamage, _maxDamage));
            return currentDamage;
        }
    }
}

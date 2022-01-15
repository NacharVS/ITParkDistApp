using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    abstract class Shooter : BattleUnit
    {
        private int _arrows;
        private int _minDistanceDamage;
        private int _maxDistanceDamage;

        protected Shooter(string name, double health, double armor, int speed, int min, int max, int minDistance, int maxDistance) : base(name, health, armor, speed, min, max)
        {
            _arrows = 5;
            _minDistanceDamage = minDistance;
            _maxDistanceDamage = maxDistance;
        }

        public int Arrows { get => _arrows;}

        protected double DistanceAttack(Random rnd)
        {
            _arrows--;
            int damage = rnd.Next(_minDistanceDamage, _maxDistanceDamage);
            return damage;
        }
    }
}

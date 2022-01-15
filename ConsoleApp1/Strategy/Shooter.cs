using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    abstract class Shooter : BattleUnit
    {
        protected int _arrows;
        protected int _minDistanceDamage;
        protected int _maxDistanceDamage;
        private double _accuracy;

        protected Shooter(string name, double health, double armor, int speed, int min, int max, int minDistance, int maxDistance, double accuracy) : base(name, health, armor, speed, min, max)
        {
            _minDistanceDamage = minDistance;
            _maxDistanceDamage = maxDistance;
        }

        public int Arrows { get => _arrows;}

        public double DistanceAttack(Random rnd)
        {
            _arrows--;
            int damage = rnd.Next(_minDistanceDamage, _maxDistanceDamage);
            
            if (_arrows <= 0)
            {
                Console.WriteLine("Arrows is empty");
            }

            return damage;
        }
    }
}

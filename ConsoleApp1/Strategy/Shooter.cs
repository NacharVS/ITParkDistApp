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
        
        protected Shooter(string name, double health, double armor, int speed, int min, int max, int minDistance, int maxDistance) : base(name, health, armor, speed, min, max)
        {
            _minDistanceDamage = minDistance;
            _maxDistanceDamage = maxDistance;
        }

        public int Arrows { get => _arrows;}

        public double DistanceAttack(Random rnd)
        {
            if (_arrows > 0)
            {
                _arrows--;
                double damage = rnd.Next(_minDistanceDamage, _maxDistanceDamage);
                return damage;
            }
                        
            else
            {
                Console.WriteLine("Arrows is empty");
                return 0;
            }
        }
    }
}

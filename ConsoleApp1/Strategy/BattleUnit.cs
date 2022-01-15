using System;

namespace ConsoleApp1.Strategy
{
    abstract class BattleUnit : MovableUnits
    {
        protected int _minDamage;
        protected int _maxDamage;

        public BattleUnit(string name, double health, double armor, int speed, int min, int max) : base(name, health, armor, speed)
        {
            _minDamage = min;
            _maxDamage = max;
        }

        abstract public double Attack(Random rnd);
        //{
        //    return 0;
        //}

        protected double MeleeAttack(Random rnd)
        {
            double damage = rnd.Next(_minDamage, _maxDamage);
            return damage;
        }

        public void Upgrade()
        {
            if(Lvl == 0)
            {
                _minDamage += 1;
                _maxDamage += 2;
                Lvl++;
            }
        }
    }
}

using System;

namespace ConsoleApp1.Strategy
{
    abstract class BattleUnit : MovableUnits
    {
        protected int _minDamage;
        protected int _maxDamage;

        private bool _isFrenzy;
        private double _multiplierDamage;

        public BattleUnit(string name, double health, double armor, int speed, int min, int max) : base(name, health, armor, speed)
        {
            _minDamage = min;
            _maxDamage = max;

            _isFrenzy = false;
            _multiplierDamage = 1;
        }

        internal bool IsFrenzy { get => _isFrenzy; set => _isFrenzy = value; }

        internal double MultiplierDamage { get => _multiplierDamage; set => _multiplierDamage = value; }

        abstract public double Attack(Random rnd);
        
        public double MeleeAttack(Random rnd)
        {
            double damage = _multiplierDamage * rnd.Next(_minDamage, _maxDamage);
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

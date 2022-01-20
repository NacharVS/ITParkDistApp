using System;

namespace ConsoleApp1.Strategy
{
    abstract class BattleUnit : MovableUnits
    {
        protected int _minDamage;
        protected int _maxDamage;

        private int _rage;
        private double _frenzy;
        private bool _isFrenzy;


        public BattleUnit(string name, double health, double armor, int speed, int min, int max) : base(name, health, armor, speed)
        {
            _minDamage = min;
            _maxDamage = max;

            _rage = 1;
            _frenzy = 1;
            _isFrenzy = false;
        }

        internal int Rage { get => _rage; set => _rage = value; }

        internal double Frenzy { get => _frenzy; set => _frenzy = value; }

        internal bool IsFrenzy { get => _isFrenzy; set => _isFrenzy = value; }

        abstract public double Attack(Random rnd);
        
        public double MeleeAttack(Random rnd)
        {
            double damage = _rage * _frenzy * rnd.Next(_minDamage, _maxDamage);
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

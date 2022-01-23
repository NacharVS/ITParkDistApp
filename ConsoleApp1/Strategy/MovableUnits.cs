using System;

namespace ConsoleApp1.Strategy
{
    class MovableUnits : Unit
    {
        public delegate void HealDelegate(string unitName, double unitHealth, double healCount);
        public delegate void DamageDelegate(string unitName, double unitHealth, double damageCount);
        public delegate void FrenzyDelegate(string unitName, int armor, double minDamage, double maxDamage);
        public delegate void MaxHealthChangeDelegate(string name, double diff);
        public string profession;
        public int speed;
        public int lvl;
        public bool Salvation { get; set; }
        public override double Health
        {
            get { return _health; }
            set
            {
                double diff = Health - value;
                if (diff > 0)
                {
                    DamageEvent?.Invoke(name, Health, (int)diff);
                }
                else
                {
                    HealEvent?.Invoke(name, Health, (int)diff);
                }
                if (value <= 0)
                {
                    if (Salvation)
                    {
                        SalvationActivate();
                        Salvation = false;
                    }
                    else
                    {
                        _health = 0;
                        Termination();
                    }
                }
                else if (value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                    _health = value;
            }
        }
        public override double MaxHealth
        {
            get => base.MaxHealth;
            set
            {
                var diff = _maxHealth - value;
                _maxHealth = value;
                MaxHealthEvent?.Invoke(name, Math.Abs(diff));
            }
        }
        private void SalvationActivate()
        {
            Health = _maxHealth;
            Console.WriteLine($"{name} is salvated!");
        }
        public void SalvationBuff(MovableUnits unit)
        {
            unit.salvationBuffStatus = true;
            Console.WriteLine($"{name} get SalvationBuff to {unit} (devine touch:)!");
        }
        public MovableUnits(string name, int health, int armor, string professionParam, int speedParam) : base(name, health, armor)
        {
            profession = professionParam;
            speed = speedParam;
            lvl = 0;
        }
        public void Move()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Has {Health} ");
        }
        public event FrenzyDelegate FrenzyEvent;
        public event DamageDelegate DamageEvent;
        public event MaxHealthChangeDelegate MaxHealthEvent;
        public event HealDelegate HealEvent;
    }
}

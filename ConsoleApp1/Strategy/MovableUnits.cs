using System;

namespace ConsoleApp1.Strategy
{
    abstract class MovableUnits : Unit
    {
        private double _speed;
        private string _profession;
        private int _lvl;

        private bool _isBoostHealth;
        private bool _isStoneSkin;
        private bool _salvation;


        public MovableUnits(string name, double maxHealth, double armor, int speed) : base(name, maxHealth, armor)
        {
            _speed = speed;
            _lvl = 0;

            _isBoostHealth = false;
            _isStoneSkin = false;
            _salvation = false;
        }

        public override double Health
        {
            get => base.Health;
            set
            {
                if (value <= 0)
                {
                    if (_salvation)
                    {
                        value = SalvationAktivate();
                        _salvation = false;
                    }
                }
                            
                base.Health = value;
            }
        }

        public double Speed { get => _speed; set => _speed = value; }

        public string Profession { get => _profession; set => _profession = value; }

        public int Lvl { get => _lvl; set => _lvl = value; }

        internal bool IsBoostHealth { get; set; }

        internal bool IsStoneSkin { get; set; }

        internal bool Salvation { get => _salvation; set => _salvation = value; }

        public void Wound(double damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} - {Profession} is under attack!");
        }

        public void GetTreatment(int healingPower)
        {
            Health += healingPower;
            Console.WriteLine($"{Name} - {Profession} is under treatment");
        }
                
        public void Move()
        {
            Console.WriteLine($"{Name}- is moving with {Speed}");
            Info();
        }

        public override void Info()
        {
            Console.WriteLine($"Name:{Name}/ Health:{Health}/ armor:{Armor}/ speed:{_speed}");
        }

        private double SalvationAktivate()
        {
            return MaxHealth;
        }
    }
}

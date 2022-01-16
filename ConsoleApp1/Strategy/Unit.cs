using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        private double _health;
        internal double _maxHealth;
        public int armor;
        public double damageReduction;
        internal bool IsCatapult;

        public virtual double Health
        {
            get { return _health; }
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Termination();
                }
                else if (value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                    _health = value * (
                        100 * (armor * 0.06) / (1 + armor * 0.06)
                        );

            }
        }

        protected Unit(string name, int health, int armor)
        {
            this.name = name;
            this._health = health;
            this.armor = armor;
            _maxHealth = health;
            this.damageReduction = Math.Ceiling(100 * (armor * 0.06) / (1 + armor * 0.06));
            IsCatapult = false;
            Creation();
        }

        public void Creation()
        {
            Console.WriteLine($"{name} is created with {Health} HP and {armor} Armor");
        }

        public void Termination()
        {
            Console.WriteLine($"{name} is terminated");
        }

        public virtual void Info()
        {
            Console.WriteLine($"{name} {Math.Round(Health)}");
        }
    }
}

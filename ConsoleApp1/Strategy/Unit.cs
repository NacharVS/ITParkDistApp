using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        internal virtual bool IsCatapult => false;

        private string _name;
        private double _maxHealth;
        private double _health;
        private double _armor;
        
        protected Unit(string name, double maxHealth, double armor)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _armor = armor;
            Creation();
        }
        
        public string Name { get => _name;}
        
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public virtual double Health
        {
            get
            {
                return _health;
            }
            set
            {
                double damage = _health - value;
                value += damage * ((0.06 * _armor) / (1 + 0.06 * _armor));

                value = (int)(value * 100);
                value = value / 100;
                                                
                if (value <= 0)
                {
                    _health = 0;
                    Termination();
                }

                else if (value >= _maxHealth)
                {
                    _health = _maxHealth;
                }

                else _health = value;
            }
        }

        internal double Armor { get => _armor; set => _armor = value; }

        public void Creation()
        {
            Console.WriteLine($"{_name} is created");
        }

        protected void Termination()
        {          
            Console.WriteLine($"{_name} is terminated");
        }

        public virtual void Info()
        {
            Console.WriteLine($"Name:{_name}/ Health:{_health}/ armor:{_armor}");
        }
    }
}

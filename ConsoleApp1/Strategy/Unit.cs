using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        private double _maxHealth;
        private double _health;
        public double armor;

        public double MaxHealth { get; set; }
        

        protected Unit(string name, double maxHealth, double armor)
        {
            this.name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            this.armor = armor;
            Creation();
        }

        public double Health
        {
            get
            {
                return _health;
            }

            set
            {
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

        public void Creation()
        {
            Console.WriteLine($"{name} is created");
        }

        public void Termination()
        {          
            Console.WriteLine($"{name} is terminated");
        }

        public void Info()
        {
            Console.WriteLine($"Name:{name}/ Health:{_health}/ armor:{armor}");
        }
    }
}

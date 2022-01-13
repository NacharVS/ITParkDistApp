using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        private  double _health;
        internal double _maxHealth;
        public int armor;

        internal double Health 
        {
            get { return _health; } 
            set
            {
                double diff = _health + value;
                if(value<=0)
                {
                    _health = 0;
                    Termination();
                }
                else if (value>_maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                {

                }
            }
        }

        protected Unit(string name, int health, int armor)
        {
            this.name = name;
            this._health = health;
            this.armor = armor;
            _maxHealth = health;
            Creation();
        }

        public void Creation()
        {
            Console.WriteLine($"{name} is created with {Health}");
        }

        public void Termination()
        {
            Console.WriteLine($"{name} is terminated");
        }

        public void Info()
        {
            Console.WriteLine($"{name} {Health}");
        }
    }
}

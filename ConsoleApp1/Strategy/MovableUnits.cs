using System;

namespace ConsoleApp1.Strategy
{
    class MovableUnits : Unit
    {
        public string profession; 
        public int speed;
        public int lvl;
        public bool Salvation { get; set; }

        public override double Health 
        {
            get { return _health; }

            set
            {
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

        public MovableUnits(string name, int health, int armor, string professionParam, int speedParam) : base(name, health, armor)
        {
            profession = professionParam;
            speed = speedParam;
            Salvation = false;
            lvl = 0;
        }

        public void Move()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Has {Health} ");
        }

        private void SalvationActivate()
        {
            _health = _maxHealth;
            Console.WriteLine($"{name} is salvated!");
        }
    }
}

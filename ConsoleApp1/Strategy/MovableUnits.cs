using System;

namespace ConsoleApp1.Strategy
{
    class MovableUnits : Unit
    {
        public delegate void HealDelegate(string unitName, double unitHealth, double healCount);
        public delegate void DamageDelegate(string unitName, double unitHealth, double damageCount);

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
                if(diff > 0)
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
            Health = _maxHealth;
            Console.WriteLine($"{name} is salvated!");
        }


        public event HealDelegate HealEvent;
        public event DamageDelegate DamageEvent;
    }
}

using System;

namespace ConsoleApp1.Strategy
{
    abstract class MovableUnits : Unit
    {
        private int _speed;
        private string _profession;
        private int _lvl;

        public MovableUnits(string name, double maxHealth, double armor, int speed) : base(name, maxHealth, armor)
        {
            _speed = speed;
           _lvl = 0;
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
        }

        public string Profession
        {
            get
            {
                return _profession;
            }
            protected set
            {
                _profession = value;
            }
        }

        public int Lvl { get => _lvl; set => _lvl = value; }
        
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
    }
}

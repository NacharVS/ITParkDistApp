using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        internal virtual bool IsCatapult { get => false; }


        public string name;
        internal double _health;
        internal double _maxHealth;
        public double Armor { get; set; }

        
        //public virtual double Armor 
        //{
        //    get { return _armor; }
        //    set { _armor = value; } 
        //}

        //public override virtual int Armor
        //{
        //    get { return armor; }
        //}
        public virtual double MaxHealth
        {
            get { return _maxHealth; }
            set
            {
                _maxHealth = value;
            }
        }

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
                    _health = value;

            }
        }

        public Unit(string name, int health, int armor)
        {
            this.name = name;
            this._health = health;
            this.Armor = armor;
            _maxHealth = health;
            Creation();
        }

        public void Creation()
        {
            Console.WriteLine($"{name} is created");
        }

        public void Termination()
        {
            Console.WriteLine($"{name} is terminated");
        }

        public virtual void Info()
        {
            Console.WriteLine($"{name} {Health}");
        }
       

    }
}
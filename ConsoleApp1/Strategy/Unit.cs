using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Unit
    {
        internal virtual bool IsCatapult { get => false; }   /*Катапульта*/
        public string name; /*Имя*/
        private double _healt;  /*здоровье*/
        public int armor; /*сопротивление урона(броня)*/
        internal double _maxHealth;

        public virtual double Healt        /*  Метод здоровья*/
        {
            get { return _healt; }
            set
            {
                if (value <= 0)
                {
                    _healt = 0;
                    Termination();
                }
                else if (value > _maxHealth)
                {
                    _healt = _maxHealth;
                }
                else
                {
                    _healt = value;
                }
            }
        }

        protected Unit(string name, int health, int armor)  /* <---КОНСТРУКТОР*/
        {

            this.name = name;
            this._healt = health;
            this.armor = armor;
            _maxHealth = Healt;
            Creation();
        }

        //МЕТОД СОЗДАНИЯ------------------------------------------------------------
        public void Creation()
        {
            Console.WriteLine($"{name} создался");
        }

        //МЕТОД УНИЧТОЖЕНИЯ------------------------------------------------------------
        public void Termination() /*Уничтожение*/
        {
            Console.WriteLine($"{name} уничтожился");
        }
        //Метод информации текущего юнита
        public virtual void Info()
        {
            if (_healt > 0)
            {
                Console.WriteLine($"{name} {Healt}");
            }
            else
            {
                if (_healt <= 0)
                {
                    Console.WriteLine($"{name} погиб");
                }
            }
        }
    }
}

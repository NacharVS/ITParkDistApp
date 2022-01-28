using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia

{
    abstract class Unit
    {
        internal virtual bool IsCatapult { get => false; }
        public string name;          //тип здания
        private double _health;        //уровень жизни
        public double armor;         //уровень брони
        internal double _maxHealt;   //макс уровень жизни

        public virtual double Health 
        {
            get { return _health; }
            set 
            {
                if(value <= 0)
                {
                    
                    _health = 0;
                    Termination();
                }
                else if(value > _maxHealt )
                {
                    _health = _maxHealt;
                }
                else
                {
                    _health = value;
                }
                
            }
        }

        protected Unit(string name, int health, int armor) //конструктор игрока
        {
            this.name = name;
            this.Health = health;
            this.armor = armor;
            _maxHealt = health;
            Creation();
        }

        public void Termination()  //метод вывода жизни
        {
            Console.WriteLine($"{name} is termination" );
        }
        public void Creation()     //создание нового игрока (unit)
        {
            Console.WriteLine($"{name} is created");
        }
        public virtual void Info()
        {
            if (_health > 0)
            {
                Console.WriteLine($"{name} {Health}");
            }
            else
            {
                if (_health <= 0)
                {
                    Console.WriteLine($"{name} погиб");
                }
            }
        }

    }
}

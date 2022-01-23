using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    abstract class Unit
    {
        public string name;       //тип здания
        public double health;        //уровень жизни
        public double armor;         //уровень брони
       

        protected Unit(string name, int health, int armor) //конструктор игрока
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            Creation();
        }

        public void Termination ()  //метод вывода жизни
        {
            Console.WriteLine($"{name} is termination" );
        }
        public void Creation()     //создание нового игрока (unit)
        {
            Console.WriteLine($"{name} is created");
        }

        public void Info()
        {
            Console.WriteLine($"{name} {health}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class MovadelUnits : Unit //движомы объект(игрок)
    {
        public int speed;           // скорость
        public string profession;   // профессия
        public int lvl;             //уровень силы(урона)
        

        public MovadelUnits(string name, int health, int armor, int speedParam, string professionParam) : base(name, health, armor)
        {
            speed = speedParam;
            profession = professionParam;
            lvl = 0;
        }

        public void Move()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Has {Health} ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class MovableUnits : Unit
    {

        public string profession;
        public int speed;
        public int lvl;
          
       

        public MovableUnits(string name, int health, int armor, string professionParam, int speedParam) : base(name, health, armor)
        {
            this.speed = speedParam;
            this. profession = professionParam;
            lvl=0;
        }

        public void Move()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Has {health} units of health ");
        }
    }
}


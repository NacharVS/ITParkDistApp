using System;

namespace ConsoleApp1.Strategy
{
    class MovableUnits : Unit
    {
        //public string profession; 
        public int speed;
        public int lvl;

        public MovableUnits(string name, double health, double armor, int speed) : base(name, health, armor)
        {
            //profession = professionParam;
            this.speed = speed;
            lvl = 0;
        }

        public void Move()
        {
            Console.WriteLine($"{name} - is moving with {speed}");
            Info();
        }
    }
}

using System;

namespace ConsoleApp1.Strategy
{
    class Buildings : Unit
    {
        public int wall;

        public Buildings(string name, int health, int armor) : base(name, health, armor)
        {
            wall = health;
        }
    }
}

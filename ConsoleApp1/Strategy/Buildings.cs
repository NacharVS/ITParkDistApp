using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
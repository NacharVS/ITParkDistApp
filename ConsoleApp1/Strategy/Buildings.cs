using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    class Buildings : Unit
    {
        private double _wall;

        public Buildings(string name, int health, int armor) : base(name, health, armor)
        {
            Wall = health;
        }

        public double Wall { get => _wall; set => _wall = value; }

        private void WallIsDestroyed()
        {
            System.Console.WriteLine("Wall is destroyed");
        }

        public override void Info()
        {
            System.Console.WriteLine($"{name} {_wall} {Health}");
        }
        

    }
}
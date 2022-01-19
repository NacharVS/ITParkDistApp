using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    class Peasant : MovableUnits
    {
        public int CarryWeight;

        public Peasant(string name) : base(name, 30, 0, "Worker", 4)
        {
            CarryWeight = 100;
        }

        public void Work()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Can carry {CarryWeight} pounds");
        }



        public void Repare(Buildings building)
        {
            if (this.Health > 5)
            {
                building.Wall += this.CarryWeight;
                Console.WriteLine($"{building.name} has been repared by {this.name} with power {this.CarryWeight}." +
                    $" Walls are {building.Wall}");
            }
            else Console.WriteLine($"{building.name} has not been repared by {this.name} " +
                    $" Walls are {building.Wall}");
            }

        }
}
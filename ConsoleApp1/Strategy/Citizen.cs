using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Citizen : MovableUnits
    {
        
        

        public Citizen(string name, double health, double armor, int speed) : base(name, health, armor, speed)
        {
           
        }

        
    }
}

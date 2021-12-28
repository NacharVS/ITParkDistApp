using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class WatingTower : Buildings
    {
        public WatingTower(string name, int health, int armor) :base("Tower",100,20)
            {

             }

       

        public void Observe()
        {
            Console.WriteLine($"{name} is Observing.Statement{wall}, {health},{armor}");
        }
    }
}

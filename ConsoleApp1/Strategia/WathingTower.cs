using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class WathingTower : Bildings        // Сторожевая Башня
    {
        public WathingTower() : base("Tower", 100, 20)
        {

        }

        public void Observe()          // Наблюдение
        {
            Console.WriteLine($"{name} isObserve. Statement {Health},{armor}");
        }
    }
}

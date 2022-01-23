using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class Bildings : Unit   //не движимое здание
    {
        public int wall; // Чит здания

        public Bildings(string name, int health, int armor) : base(name, health, armor)
        {
            wall = health;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    internal class Catapult : BattleUnit
    {
        public Catapult(string name, int health, int armor, string professionParam, int speedParam, int min, int max) : base(name, health, armor, professionParam, speedParam, min, max)
        {
        }
    }
}

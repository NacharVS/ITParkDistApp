using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : MovableUnits
    {
        public double healAmount;
        public Healer(string name, double healAmountParam) : base(name, 50, 5, "Healer", 7)
        {
            healAmount = healAmountParam;
        }

        public void Heal(MovableUnits unit)
        {
            unit.health += healAmount;
        }
    }
}

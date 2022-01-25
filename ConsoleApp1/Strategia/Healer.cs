using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class Healer : MovadelUnits     // Полевой лекарь
    {
        public double healAmount;

        public Healer(string name, double healAmountParam) : base(name, 50, 5, 7, "Healer")
        {
            healAmount = healAmountParam;
        }

        public void Heal(MovadelUnits unit )
        {
            if(unit.health + healAmount >= unit._maxHealt)
            {
                unit.health = unit._maxHealt;
            }
            else
            {
                unit.health += healAmount;
            }
            
            
        }
    }
}

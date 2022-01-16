using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : MovableUnits
    {
        public int mana;
        public double healAmount;

        public Healer(string name,int health, int mana, int armor, double healAmount) : base(name, health, armor, "Healer", 7)
        {
            this.healAmount = healAmount;
            this.mana = mana;
        }

        public void Heal(MovableUnits unit)
        {
            if (unit.Health + healAmount >= unit._maxHealth)
            {
                unit.Health = unit._maxHealth;
            }
            else
            {
                unit.Health += healAmount;
                mana -= 5;
            }
        }
    }
}

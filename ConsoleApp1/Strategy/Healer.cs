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
        private int _maxMana;
        public double healAmount;

        public Healer(string name, int health, int mana, int armor) : base(name, health, armor, "Healer", 7)
        {
            this.mana = mana;
            this._maxMana = mana;
            this.healAmount = 25;
        }

        public void Heal(MovableUnits unit)
        {
            Console.WriteLine($"{name} begin to heal {unit.name} ({unit.Health} HP)");
            while (mana>0)
            {
                if (unit.Health + healAmount >= unit._maxHealth)
                {
                    unit.Health = unit._maxHealth;
                    Console.WriteLine($"  {unit.name}'s HP is FULL! ({unit._maxHealth})");
                    break;
                }
                else if(unit.Health + healAmount < unit._maxHealth)
                {
                    unit.Health += healAmount;
                    mana -= 25;
                    Console.WriteLine($"    {name}(mana={mana}/{_maxMana}) heal {unit.name}({unit.Health} HP) by {healAmount}");
                }
                else if(mana<=0) Console.Write($"\t{name}'s mana is empty: {mana}/{_maxMana} =>");
            }
            
            unit.Info();
        }
    }
}

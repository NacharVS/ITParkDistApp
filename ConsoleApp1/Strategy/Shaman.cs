using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Shaman : MovableUnits
    {
        public int mana;
        private int _maxMana;

        public Shaman(string name, int health, int mana, int armor) : base(name, health, armor, "Shaman", 7)
        {
            this.mana = mana;
            this._maxMana = mana;
        }

        public void HealthBoost(MovableUnits unit)
        {
            Console.WriteLine($"Shaman begin casts the HealthBoost on {unit.name}(current HP:{unit.Health})");
            if (mana > 0)
            {
                if (!unit.hpBoostStatus)
                {
                    unit._maxHealth = unit._maxHealth * 1.5;
                    mana -= 50;
                    unit.hpBoostStatus = true;
                    Console.WriteLine($"  Shaman increase {unit.name}'s HP by 50% (current HP:{unit.Health}/{unit._maxHealth})");
                }
                else Console.WriteLine($"    {unit.name} already have the HealthBoost {unit.Health}/{unit._maxHealth}");
            }
            else Console.WriteLine($"      {name}'s mana is empty: {mana}/{_maxMana}");
        }
        public void Frenzy (BattleUnit unit)
        {
            Console.WriteLine($"Shaman begin casts the Frenzy on {unit.name}(current damage:{unit.minDamage}-{unit.maxDamage}, armor:{unit.armor})");
            if (mana > 0)
            {
                if (!unit.FrenzyStatus)
                {
                    unit.armor = unit.armor*0.5;
                    unit.minDamage = unit.minDamage*1.5;
                    unit.maxDamage = unit.maxDamage*1.5;
                    unit.FrenzyStatus = true;
                    Console.WriteLine($"  Shaman increase {unit.name}'s damage by 2 (current damage:{unit.minDamage}-{unit.maxDamage}) and decrease armor ({unit.armor})");
                    mana -= 50;
                }
                else Console.WriteLine($"    {unit.name} already have the Frenzy {unit.Health}");
            }
            else Console.WriteLine($"      {name}'s mana is empty: {mana}/{_maxMana}");
        }
        public void StoneSkin(BattleUnit unit)
        {
            Console.WriteLine($"Shaman begin casts the StoneSkin on {unit.name}(current speed:{unit.speed}, armor:{unit.armor})");
            if (mana > 0)
            {
                if (!unit.stoneSkinStatus)
                {
                    unit.armor = unit.armor*2;
                    unit.speed = unit.speed / 2;
                    mana -= 100;
                    unit.stoneSkinStatus = true;
                    Console.WriteLine($"  Shaman increase {unit.name}'s armor by 2x (current armor:{unit.armor}) and decrease speed ({unit.speed})");
                }
                else Console.WriteLine($"    {unit.name} already have the StoneSkin (armor:{unit.armor})");
            }
            else Console.WriteLine($"      {name}'s mana is empty: {mana}/{_maxMana}");
        }
    }
}

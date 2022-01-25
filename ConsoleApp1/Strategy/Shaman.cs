using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Shaman: MovableUnits
    {
        private int _mana;
        public Shaman(string name) : base(name, 50, 1, "Jinn", 7)
        {
            _mana = 50;
        }
        public void BoostHealth(MovableUnits unit)
        {
            if ((_mana > 0) && (!unit.IsHealthBoosted))
            {
                if (0 < unit.health)
                {
                    _mana -= 10;
                    unit._maxHealth = unit._maxHealth * 1.5  ;
                    unit.IsHealthBoosted = !unit.IsHealthBoosted;
                    Console.WriteLine($"{name} boost health for {unit.name} by 50%. {unit.name} has {unit._maxHealth} hp");
                    Console.WriteLine($"{name} spent -10 mana. {name} has {_mana} mana.");
                }
                else
                    if (unit.health <= 0)
                {
                    Console.WriteLine($"{unit.name} is death.");
                }
            }
            else
                if (_mana <= 0)
            {
                Console.WriteLine($"{name} don't have mana.");
            }
            else
                if (unit.IsHealthBoosted)
            {
                Console.WriteLine($"{name} boost health can only be used once.");
            }
        }
        public void Frenzy(BattleUnit unit)
        {
            if ((_mana > 0) && (!unit.IsFrenzy))
            {
                if (0 < unit.health)
                {
                    unit.minDamage = Convert.ToInt32(unit.minDamage * 1.5);
                    unit.maxDamage = Convert.ToInt32(unit.maxDamage * 1.5);
                    unit.armor = Convert.ToInt32(unit.armor * 0.5);
                    unit.IsFrenzy = !unit.IsFrenzy;
                    Console.WriteLine($"{name} boost Frenzy for {unit.name}. {unit.name} has {unit.maxDamage} damage but armor is halved {unit.armor}");
                    Console.WriteLine($"{name} spent -10 mana. {name} has {_mana} mana.");
                }
                else
                if (unit.health <= 0)
                {
                    Console.WriteLine($"{unit.name} is death.");
                }
            }
            else
                if (_mana <= 0)
            {
                Console.WriteLine($"{name} don't have mana.");
            }
            else
                if (unit.IsFrenzy)
            {
                Console.WriteLine($"{name} boost Frenzy can only be used once.");
            }
        }
        public void StoneSkin(MovableUnits unit)
        {
            if ((_mana > 0)&&(!unit.IsStoneSkin))
            {
                if (0 < unit.health)
                {
                    _mana -= 10;
                    unit.armor = unit.armor * 2;
                    unit.speed = unit.speed / 2;
                    unit.IsStoneSkin = !unit.IsStoneSkin;
                    Console.WriteLine($"{name} boost StoneSkin for {unit.name}. {unit.name} has {unit.armor} armor but speed is halved {unit.speed}");
                    Console.WriteLine($"{name} spent -10 mana. {name} has {_mana} mana.");
                }
                else
                if (unit.health <= 0)
                {
                    Console.WriteLine($"{unit.name} is death.");
                }
            }
            else
                if (_mana <= 0)
            {
                Console.WriteLine($"{name} don't have mana.");
            }
            else
                if (unit.IsStoneSkin)
            {
                Console.WriteLine($"{name} boost StoneSkin can only be used once.");
            }
        }
    }
}

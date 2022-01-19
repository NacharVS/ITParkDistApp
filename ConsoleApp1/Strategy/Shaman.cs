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
        private double _boostfrenzy;
        public bool boostHealth { get; private set; }
        public bool boostFrenzy { get; private set; }
        public bool booststoneSkin { get; private set; }
        public Shaman(string name) : base(name, 50, 1, "Jinn", 7)
        {
            _mana = 50;
        }
        public void BoostHealth(MovableUnits unit)
        {
            if ((_mana > 0) && (boostFrenzy = false) && (booststoneSkin = false))
            {
                if (0 < unit.health)
                {
                    _mana -= 10;
                    unit._maxHealth = unit._maxHealth * 1.5  ;
                    boostHealth = true;
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
        }
        public void Frenzy(BattleUnit unit, Random rnd)
        {
            if ((_mana > 0)&&(boostHealth=false)&&(booststoneSkin=false))
            {
                if (0 < unit.health)
                {
                    //unit.minDamage = 2+unit.minDamage;
                    //unit.maxDamage = 2+unit.maxDamage;
                    //_mana -= 10;
                    //unit.minDamage = MleeAttack(Random rnd)) +2;
                    //unit.maxDamage = Convert.ToDouble(rnd.Next(unit.maxDamage)) +2;
                    boostFrenzy = true;
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
        }
        public void StoneSkin(MovableUnits unit)
        {
            if ((_mana > 0)&& (boostHealth = false) && (boostFrenzy = false))
            {
                if (0 < unit.health)
                {
                    _mana -= 10;
                    unit.armor = unit.armor * 2;
                    unit.speed = unit.speed / 2;
                    booststoneSkin = true;
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
        }
    }
}

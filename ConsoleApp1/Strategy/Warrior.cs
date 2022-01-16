using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : BattleUnit
    {
        private bool _rage = false;
        //public override double Health
        //{
        //    get { return Health; }
        //    set
        //    {
        //        if (value < Health * 0.4)
        //        {
        //            _rage = true;
        //            Console.WriteLine($"{name} RAGE!");
        //            Health = value;
        //        }
        //        else if (value > _maxHealth * 0.4 && _rage == true)
        //        {
        //            _rage = false;
        //            Console.WriteLine($"{name} rage is over.");
        //            Health = value;
        //        }
        //    }
        //}
        public bool Rage { get => _rage; set => _rage = value; }

        public Warrior(string name, int health, int armor) : base(name, health, armor, "soldier", 5, 7, 18)
        {
        }

        public override double MeeleeAttack(Random rnd)
        {
            if (_rage == false)
            {
                return base.MeeleeAttack(rnd);
            }
            else
            {
                return base.MeeleeAttack(rnd) * 2;
            }

        }
    }
}

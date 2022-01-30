
using ConsoleApp1.StrategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyNew
{
    class StoneAxe : IMleeWeapon
    {
        public double Damage { get => 3; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 5; set => throw new NotImplementedException(); }

        public int durability;

        public bool chanseOfBlock;
    }
}

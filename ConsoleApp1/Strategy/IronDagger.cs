using ConsoleApp1.StrategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class IronDagger: IMleeWeapon
    {
        public double Damage { get => 2; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 10; set => throw new NotImplementedException(); }
    }
}

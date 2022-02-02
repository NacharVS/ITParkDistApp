using ConsoleApp1.StategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class ShortSword : IMleeWeapon
    {
        public double Damage { get => 5; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 7; set => throw new NotImplementedException(); }
    }
}

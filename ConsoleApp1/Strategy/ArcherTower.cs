using ConsoleApp1.StategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class ArcherTower : IBattleUnit
    {
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMleeWeapon weapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack(double dmg)
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}

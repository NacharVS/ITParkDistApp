using ConsoleApp1.StrategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : IBattleUnit
    {
        IRangeEwapon rWeapon;
        IMleeWeapon mWeapon;

        public Archer(IRangeEwapon rWeapon, IMleeWeapon mWeapon)
        {
            this.rWeapon = rWeapon;
            this.mWeapon = mWeapon;
        }

        public void Attack(double dmg)
        {
            throw new NotImplementedException();
        }
    }

}

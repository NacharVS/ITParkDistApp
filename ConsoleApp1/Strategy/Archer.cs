using ConsoleApp1.StategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : IBattleUnit
    {
        IRangeWeapon rWeapon;
        IMleeWeapon mWeapon;

        public Archer(IRangeWeapon rWeapon, IMleeWeapon mWeapon)
        {
            this.rWeapon = rWeapon;
            this.mWeapon = mWeapon;
        }

        public void Attack()
        {
            if (rWeapon.IsEmpty)
            {
                Console.WriteLine($"attack {mWeapon.Damage}");
            }
            else
            {
                Console.WriteLine($"Range damag {rWeapon.RangeDamage}");
                rWeapon.Shoot();
            }
        }
    }
}

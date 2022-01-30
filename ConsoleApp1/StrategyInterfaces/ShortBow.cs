using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    class ShortBow : IRangeWeapon
    {
        public double RangeDamage { get => 20; set => throw new NotImplementedException(); }
        public bool IsEmpty { get => false; set => throw new NotImplementedException(); }
        private int _arrowsCount;

        public ShortBow(int arrowsCount)
        {
            _arrowsCount = arrowsCount;
        }
        private void Shoot()
        {
            if (_arrowsCount > 0)
                _arrowsCount--;
            else
                IsEmpty = true;
        }

    }
}

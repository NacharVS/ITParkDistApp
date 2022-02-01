using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StategyInterfaces
{
    class ShortBow : IRangeWeapon, IRepairible
    {
        public double RangeDamage { get => 20; }

        private bool _isEmpty;
        public bool IsEmpty { get => _isEmpty; set => _isEmpty = value; }

        private int _arrowsCount;

        public ShortBow(int arrowsCount)
        {
            _arrowsCount = arrowsCount;
        }

        public void Shoot()
        {
            if (_arrowsCount > 0)
                _arrowsCount--;
            else
                IsEmpty = true;
        }

        public void Repair()
        {
            throw new NotImplementedException();
        }
    }
}

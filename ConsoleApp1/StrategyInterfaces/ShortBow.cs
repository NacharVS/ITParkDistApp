using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyInterfaces
{
    class ShortBow : IRangeEwapon
    {
        public double RangeDamage { get =>20; set => throw new NotImplementedException(); }
        private int ArrowsCount;

        public ShortBow(int arrowsCount)
        {
            ArrowsCount = arrowsCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Mechanic
    {
        public void Repair(IRepairible item)
        {
            item.Repair();
        }

        internal static object MakeMachinegun(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void UpgradeDamage(IUpgradeble item)
        {
            item.UpgradeDamage();
        }

        internal void Repair(Knife knife)
        {
            throw new NotImplementedException();
        }
    }
}

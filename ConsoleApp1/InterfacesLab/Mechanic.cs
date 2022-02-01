using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    internal class Mechanic
    {
        public void Repair(IRepairable item)
        {
            item.Repair();
        }

        public void UpgradeDamage(IUpgradable item)
        {
            item.UpgradeDamage();
        }

        public static Machinegun MakeMachinegun(int dmg, int durability)
        {
            return new Machinegun(dmg, durability);
        }
    }
}

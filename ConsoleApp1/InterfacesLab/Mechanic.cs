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
        public void UpgradeDamage(IUpgradeble item)
        {
            item.UpgradDamage();
        }
         
        public static  Machinegun MakeMachinegun(int dmg,int durability)
        {
            return new Machinegun(dmg, durability);
        }
        

        
    }
}

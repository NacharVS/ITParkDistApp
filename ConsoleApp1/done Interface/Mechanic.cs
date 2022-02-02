using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.done_Interface
{
    internal class Mechanic
    {

        public void Repair(IRepairible item)
        {
            item.Repair();
        }
        public void UpgradeDamage(IUpgradeble item)
        {
            item.UpgradeDamage();
        }
        public static Machinegun MakeMachinegun(int dmg, int durability)
        {
            return new Machinegun(dmg, durability);
        }

        public static Shotgun MakeShotgun (int damage, int durability)
        {
            return new Shotgun(damage, durability);
        }

        public static Pistol MakePistol(int damage, int durability)
        {
            return new Pistol(damage, durability);
        }
        public static Shuriken MakeShuriken (int damage, int durability)
        {
            return new Shuriken (damage, durability);
        }

        public static BrassKnuckles MakeBrassKnuckles ( int durability)
        {
            return new BrassKnuckles (durability);
        }


    }
}

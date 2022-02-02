using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.done_Interface
{
    internal class BrassKnuckles : IMleeWeapon, IRepairible, IUpgradeble
    {
        public int MleeDamage => 2;

        private int _durability;

        public int Durability { get => _durability; set => _durability = value; }

        public BrassKnuckles( int durability)
        {
          _durability = durability;
        }

        public void Hit()
        {
            Console.WriteLine($"{GetType().Name} inflicted {MleeDamage} of MleeDamage");
            DicreaseDurability(2);
        }
        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }
        public void Repair()
        {
            Durability += 3;
            Console.WriteLine($"{GetType().Name} has repaired by 3");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }

        public void UpgradeDamage()
        {
            Console.WriteLine($"new mDamage {MleeDamage + 3}");
        }


    }
}

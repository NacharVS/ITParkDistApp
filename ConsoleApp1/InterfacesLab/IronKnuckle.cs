using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class IronKnuckle
    {
        public int MleeDamage => 3;

        private int _durability;

        public IronKnuckle(int durability)
        {
            _durability = durability;
        }
        public int Durability { get => _durability; set => _durability = value; }

        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }
        public void Hit()
        {
            Console.WriteLine($"{GetType().Name} inflicted {MleeDamage} of MleeDamage");
            DicreaseDurability(2);
        }
        public void Repair()
        {
            Durability += 3;
        }
        public void UpgradeDamage()
        {
            Console.WriteLine($"new mDamage{MleeDamage + 5}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }
    }
}

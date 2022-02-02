using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.done_Interface
{
    internal class Shuriken : IThrowable, IRepairible, IUpgradeble
    {
        private int _damage;
        private int _durability;

        public int Durability { get => _durability; set => _durability = value; }
        public int ThrowDamage { get => _damage; set => _damage = value; }

        public Shuriken(int damage, int durability)
        {
            _damage = damage;
            _durability = durability;
        }
        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }
        public void Throw()
        {
            Console.WriteLine($"{GetType().Name} inflicted {ThrowDamage} of ThrowDamage");
            DicreaseDurability(1);
        }

        public void Repair()
        {
            Durability += 3;
            Console.WriteLine($"{GetType().Name} has repaired by 3");
        }

        public void UpgradeDamage()
        {
            Console.WriteLine($"new ThrowDamage {ThrowDamage + 3}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }

    }
}

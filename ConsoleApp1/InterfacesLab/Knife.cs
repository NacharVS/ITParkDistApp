using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Knife : IMeeleeWeapon, IThrowable
    {
        public int MleeDamage => 3;

        private int _durability;

        public Knife(int durability)
        {
            _durability = durability;
        }

        public int ThrowDamage { get => 5; set => throw new NotImplementedException(); }
        public int Durability { get => _durability; set => _durability = value; }

        public void Hit()
        {
            Console.WriteLine($"{GetType().Name} inflicted {MleeDamage} of MeeleeDamage");
            DicreaseDurability(2);
        }

        public void Repair()
        {
            Durability += 3;
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name} inflicted {ThrowDamage} of range damage");
        }

        public void UpgradeDamage()
        {
            Console.WriteLine($"new mDamage{MleeDamage + 5}");
            Console.WriteLine($"new TDamage{ThrowDamage + 5}");
        }

        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Knife : IMleeWeapon, IThrowable
    {
        public int MleeDamage => 3;

        private int _durability;

        public Knife(int durability)
        {
            _durability = durability;
        }

        
        public int Durability { get => _durability; set => _durability = value; }
        int IThrowable.ThrowDamage { get => 7; set => throw new NotImplementedException(); }

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
            //Console.WriteLine($"new TDamage{ThrowDamage + 5}");
        }

        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }

        void IThrowable.Hit()
        {
            Console.WriteLine($"{GetType().Name} inflicted of TrowableDamage");
        }
    }
}

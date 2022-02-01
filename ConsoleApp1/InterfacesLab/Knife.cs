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


    
        public int ThrowDamage { get => 5; set => throw new NotImplementedException(); }
        public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Hit()
        {
            Console.WriteLine($"{GetType().Name} inflicted {MleeDamage} of MleeDamage");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
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
    }
}

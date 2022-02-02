using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Knife : IMleeWeapon,IThrowable
    {
        public int MleeDamage => 3;



        public int ThrowDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            Console.WriteLine($"{GetType().Name} inflicted {ThrowDamage} ofrange damage");
        }

        public void UpgradDamage()
        {
            Console.WriteLine($" New damage = {MleeDamage+5}");
            Console.WriteLine($" New TDamage = {ThrowDamage + 5}");
        }
    }
}

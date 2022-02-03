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

        private int _durability;

        public Knife(int durability)
        {
            _durability = durability;
        }

        public int ThrowDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Durabiliry { get=>_durability; set=> _durability= value; }

        public void Hit()
        {
            Console.WriteLine($"{GetType().Name} inflicted {MleeDamage} of MleeDamage");
            DicreaseDurability(2);
        }

        public void Repair()
        {
            Durabiliry += 3;
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

        private void DicreaseDurability(int value)
        {
            Durabiliry -= value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durabiliry}");
        }
    }
}

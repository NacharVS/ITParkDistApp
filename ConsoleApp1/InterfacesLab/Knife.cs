using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    internal class Knife : IMeeleeWeapon
    {
        private int _throwDamage=5;
        private int _hitDamage=10;
        public int Damage { get => 5; set => throw new NotImplementedException(); }

        public void MeeleeWeaponHit()
        {
            Console.WriteLine($"{GetType().Name} hit by {_hitDamage} damage");
        }

        public void MeeleeWeaponThrow()
        {
            Console.WriteLine($"{GetType().Name} throw by {_throwDamage} damage");
        }
    }
}

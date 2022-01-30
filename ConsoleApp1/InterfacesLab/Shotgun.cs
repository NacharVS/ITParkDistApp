using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Shotgun : iWeapon
    {
        private int _damage;
        public int Damage { get => 30; set => _damage = value; }

        public void Shoot()
        {
            Console.WriteLine($"Shotgun shooting with {Damage}");
        }
    }
}

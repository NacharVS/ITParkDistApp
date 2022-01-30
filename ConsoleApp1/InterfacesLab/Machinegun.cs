using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Machinegun : IWeapon, IReload
    {
        private int _damage;
        public double _range;
        public int Damage { get => 10; set => _damage = value; }

        public void Shoot()
        {
            Console.WriteLine($"Machinegun shooting with {Damage}");
        }

        public void Reload()
        {
            Console.WriteLine("Bullets 9 mm");
        }
    }
}

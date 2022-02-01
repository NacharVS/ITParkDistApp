using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Machinegun
    {
        private int _damage;
        public double _range;
        public int Damage { get => _damage; set => _damage = value; }

        public void Shoot()
        {
            Console.WriteLine($"Machinegun shooting with {Damage}");
        }

        public void Reload()
        {
            Console.WriteLine("Bullets 9 mm");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
        }

        public void UpgradeDamage()
        {
            Damage = Damage + 5;
        }
    }
}

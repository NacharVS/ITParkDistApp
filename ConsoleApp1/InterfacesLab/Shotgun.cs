using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Shotgun
    {
        private int _damage;
        public int Damage { get => 30; set => _damage = value; }

        public void Reload()
        {
            Console.WriteLine("12 Shells");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
        }

        public void Shoot()
        {
            Console.WriteLine($"Shotgun shooting witn {Damage}");
        }

        public void UpgradeDamage()
        {
            throw new NotImplementedException();
        }
    }
}

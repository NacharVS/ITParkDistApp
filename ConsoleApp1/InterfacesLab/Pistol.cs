using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Pistol : IWeapon
    {
        private int _damage;
        public int Damage { get => 3; set => _damage = value; }

        public void Reload()
        {
            Console.WriteLine($"45mm Bullets");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
        }

        public void Shoot()
        {
            Console.WriteLine($"Pistol shooting with {Damage}");
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public void SingleShoot()
        {
            throw new NotImplementedException();
        }

        public void UpgradDamage()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Pistol : IWeapon
    {
        //private int _damage;
        //public double _range;
        //public int Damage { get => _damage; set => _damage = value; }

        private int _damage;
        private int _durability;
        private int _maxDurability;
        

        public Pistol(int startDamage, int durability)
        {
            _damage = startDamage;
            _durability = durability;
            _maxDurability = durability;
        }
        public int Damage { get => 3; set => _damage = value; }
        public int Durability
        {
            get => _durability;
            set => _durability = value;
        }

        public void Reload()
        {
            Console.WriteLine("Bullets 45");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
            Durability += 3;
        }

        //public void Shoot()
        //{
        //    Console.WriteLine($"Pistol shooting witn {Damage}");
        //}

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }

        public void SingleShoot()
        {
            if (Durability <= 0)
            {
                Console.WriteLine($"{GetType().Name} is broken");
            }
            else
            {
                Console.WriteLine($"Machinegun shooting with {Damage}");
                DicreaseDurability(1);
            }
        }
        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }

        public void UpgradeDamage()
        {
            Damage = Damage + 5;
        }
    }
}

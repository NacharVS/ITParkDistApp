using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Pistol
    {
        private int _damage;
        private int _durability;
        private int _maxDurability;
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
            Durability += 5;
            Console.WriteLine($"{GetType().Name} gun has repaired by 5");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }
        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }
        public void SingleShoot()
        {
            Console.WriteLine($"Machinegun shooting with {Damage}");
            DicreaseDurability(1);
        }

        public void UpgradeDamage()
        {
            Damage = Damage + 5;
        }
    }
}

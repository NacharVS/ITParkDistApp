using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Machinegun : IWeapon , ITripleShoot
    {
        private int _damage;
        private int _durability;
        private int _maxDurability;

        public Machinegun(int startDamage, int durability)
        {
            _damage = startDamage;
            _durability = durability;
            _maxDurability = durability;
        }

        public int Damage { get => _damage; set => _damage = value; }
        public int Durability 
        { 
            get=>_durability; 
            set=>_durability=value; 
        }

        public void SingleShoot()
        {
            Console.WriteLine($"Machinegun  shooting with {Damage}");
            DicreaseDurability(1);
        }

        public void Reload()
        {
            Console.WriteLine("Bullets 9 mm");
        }

        public void Repair()
        {
            Durability += 5;
            Console.WriteLine($"{GetType().Name} gun has repaired by 5");
        }

        public void UpgradDamage()
        {
            Damage = Damage + 5;
        }

        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }

        public void TripleShoot()
        {
            Console.WriteLine($"Machinegun  shooting with {Damage*3}");
            DicreaseDurability(3);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }
    }
}

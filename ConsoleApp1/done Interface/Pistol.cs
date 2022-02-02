using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
   public class Pistol:IWeapon
    
    {   private int _damage;
        private int _durability;

        public int Damage { get => _damage; set => _damage = value; }
        public int Durability { get => _durability; set => _durability = value; }

        public Pistol (int damage, int durability)
        {
            _damage = damage;
            _durability = durability;
        }

        public void Reload()
        {
            Console.WriteLine("Bullets 45");
        }

        public void Repair()
        {
            Durability += 3;
            Console.WriteLine($"{GetType().Name} gun has repaired by 3");
        }

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
            Damage = Damage + 3;
        }
    }
}

using System;

namespace ConsoleApp1.InterfacesLab
{
    class Shotgun : IWeapon
    {
        private int _damage;
        private int _durability;
        private int _maxDurability;


        public Shotgun(int startDamage, int durability)
        {
            _damage = startDamage;
            _durability = durability;
            _maxDurability = durability;
        }

        public int Durability
        {
            get => _durability;
            set => _durability = value;
        }


        public int Damage { get => 30; set => _damage = value; }

        public void Reload()
        {
            Console.WriteLine("12 Shells");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
            Durability += 3;
        }

        //public void Shoot()
        //{
        //    Console.WriteLine($"Shotgun shooting witn {Damage}");
        //}

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

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");

        }



        public void UpgradeDamage()
        {
            Damage = Damage + 5;
        }
    }
}

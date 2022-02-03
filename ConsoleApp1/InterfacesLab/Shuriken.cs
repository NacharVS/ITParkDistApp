using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Shuriken: IThrowable
    {
        private int _durability;
        public Shuriken(int durability)
        {
            _durability = durability;
        }
        public int ThrowDamage { get => 25; set => throw new NotImplementedException(); }
        public int Durability { get => _durability; set => _durability = value; }
        public void Repair()
        {
            Durability += 3;
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name} inflicted {ThrowDamage} of range damage");
            DicreaseDurability(2);
        }
        public void UpgradeDamage()
        {
            Console.WriteLine($"new TDamage{ThrowDamage + 5}");
        }

        private void DicreaseDurability(int value)
        {
            Durability -= value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} durability {Durability}");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Pistol
    {
        private int _damage;
        public int Damage { get => 3; set => _damage = value; }

        public void Reload()
        {
            Console.WriteLine("Bullets 45");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} gun has repaired");
        }

        public void Shoot()
        {
            Console.WriteLine($"Pistol shooting witn {Damage}");
        }

        public void UpgradeDamage()
        {
            throw new NotImplementedException();
        }
    }
}

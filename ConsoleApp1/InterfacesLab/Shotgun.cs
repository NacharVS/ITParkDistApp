﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Shotgun : IWeapon
    {
        private int _damage;
        public int Damage { get => 30; set => _damage = value; }
        public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Reload()
        {
            throw new NotImplementedException();
        }

        public void Repair()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            Console.WriteLine($"Shotgun shooting with {Damage}");
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public void SingleShoot()
        {
            throw new NotImplementedException();
        }

        public void UpgradeDamage()
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    interface IWeapon : IReloadable, IRepairable, IUpgradable
    {
        int Damage { get; set; }

        void SingleShoot();

        void ShowInfo();
    }
} 
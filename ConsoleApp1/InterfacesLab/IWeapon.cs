﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    interface IWeapon
    {
        int Damage { get; set; }

        void Shoot();
        
    }
}

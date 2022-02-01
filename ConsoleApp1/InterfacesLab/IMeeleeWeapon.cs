using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    interface IMeeleeWeapon : IRepairable, IUpgradable
    {
        int MleeDamage { get; }
        void Hit();
        void ShowInfo();
    }
}

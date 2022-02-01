using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    interface IMleeWeapon : IRepairible, IUpgradeble
    {
        int MleeDamage { get; }


        void Hit();

    }
}

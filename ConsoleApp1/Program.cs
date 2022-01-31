using ConsoleApp1.InterfacesLab;
using ConsoleApp1.Strategia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pistol pistol1 = new Pistol();
            IWeapon weapon1 = pistol1;
            IWeapon weapon2 = new Shotgun();
            IWeapon weapon3 = new Machinegun();
            IReloat rid = pistol1;
            weapon1.Shoot();
            rid.Reload();

            List<IWeapon> weapons = new List<IWeapon>();
            weapons.Add(new Pistol());
            weapons.Add(new Machinegun());
            weapons.Add(new Shotgun());
        }
    }
}

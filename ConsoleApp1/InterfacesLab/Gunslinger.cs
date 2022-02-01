using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    internal class Gunslinger
    {
        List<IWeapon> inventory = new List<IWeapon>();
        public IMeeleeWeapon pocket;

        public void PickUpItem(IWeapon item)
        {
            inventory.Add(item);
        }
        public void Fire(IWeapon weapon)
        {
            weapon.SingleShoot();
        }

        public void MultiFire(ITripleShoot weapon)
        {
            weapon.TripleShoot();
        }

        public void FireFromAllWeapons()
        {
            foreach (var item in inventory)
            {
                item.SingleShoot();
            }
        }

        public void Reload(IReloadable item)
        {
            item.Reload();
        }

        public void HitByKnife()
        {
            pocket.Hit();
        }
    }
}

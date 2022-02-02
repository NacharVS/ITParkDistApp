using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfacesLab
{
    class Gunslinger
    {
        List<IWeapon> inventory = new List<IWeapon>();
        public IMleeWeapon pocket;
        public void PickUpItem(IWeapon item)
        {
            inventory.Add(item);
        }
        public void Fire(IWeapon weapon)
        {
            weapon.SingleShoot();
        }

        public void MultyFire(ITripleShoot weapon)
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
        public void Reload(IReloat item)
        {
            item.Reload();
        }

        public void HitByKnife()
        {
            pocket.Hit();
        }
    }
}

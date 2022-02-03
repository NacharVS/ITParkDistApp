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

        public void Reload(IReload item)
        {
            item.Reload();
        }

        public void HitByKnife(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

        public void ThrowKnife(IThrowable weapon)
        {
            weapon.Hit();
        }
    }
}

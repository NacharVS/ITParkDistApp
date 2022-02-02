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
        internal Knife pocket;

        public void PickUpItem(IWeapon item)
        {
            inventory.Add(item);
        }
        public void Fire(IWeapon weapon)
        {
            weapon.Shoot();
        }

        public void FireFromAllWeapons()
        {
            foreach (var item in inventory)
            {
                item.Shoot();
            }
        }

        internal void HitByKnife()
        {
            throw new NotImplementedException();
        }

        public void Reload(IReload item)
        {
            item.Reload();
        }
    }
}

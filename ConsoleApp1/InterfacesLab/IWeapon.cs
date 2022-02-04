using ConsoleApp1.StategyInterfaces;

namespace ConsoleApp1.InterfacesLab
{
    interface IWeapon : IReload, IRepairible, IUpgradeble
    {
        int Damage { get; set; }

        void SingleShoot();

        void ShowInfo();
    }
}
using ConsoleApp1.StategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class ArcherTower : IBattleUnit
    {
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMleeWeapon weapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack(double dmg)
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
    //class ArcherTower : Buildings
    //{
    //    private List<Archer> archers = new List<Archer>();

    //    public ArcherTower() : base("Archer Tower", 150, 30)
    //    {
    //        IsFull = false;
    //        CanAttack = false;
    //    }

    //    public bool IsFull { get; set; }
    //    public bool CanAttack { get; private set; }

    //    public void LoadArchers(Archer archer)
    //    {
    //        if (archers.Count >= 5)
    //        {
    //            Console.WriteLine("Tower is full");
    //            IsFull = true;
    //        }
    //        else
    //        {
    //            archers.Add(archer);
    //            CanAttack = true;
    //        }

    //    }


    //    public double Attack(Random rnd)
    //    {
    //        double totalDamage = 0;
    //        foreach (var item in archers)
    //        {
    //            totalDamage += item.RangeAttack(rnd);
    //        }
    //        return totalDamage;
    //    }

    //}
}

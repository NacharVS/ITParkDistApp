using ConsoleApp1.StategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Warrior : IMovableUnit, IBattleUnit
    {
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MovingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Grade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Expirience { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMleeWeapon weapon;

        public event Action CreateEvent;
        public event Action DeathEvent;

        public void Attack()
        {
            Console.WriteLine($"inflicted {weapon.Damage} with {weapon.AttackSpeed} speed");
        }

        public void LevelUp()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }

    //class Warrior : BattleUnit
    //{
    //    private bool _rage = false;

    //    public Warrior(string name) : base(name, 90, 10, "soldier", 5, 2, 8)
    //    {
    //    }

    //    public override double MleeAttack(Random rnd)
    //    {
    //        if (Health > 0.4 * _maxHealth && _rage == false)
    //        {
    //            return base.MleeAttack(rnd);
    //        }
    //        else
    //        {
    //            _rage = true;
    //            Console.WriteLine($"{name} RAGE!");
    //            return base.MleeAttack(rnd) * 2;
    //        }
    //    }
    //}
}

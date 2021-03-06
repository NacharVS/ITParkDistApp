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
}

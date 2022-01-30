using ConsoleApp1.StrategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StrategyNew
{
    internal class Peasant : IMovableUnit
    {
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MovingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Grade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Expirience { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action CreateEvent;
        public event Action DeathEvent;

        public void LevelUp()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
        private void Death()
        {
            Console.WriteLine("IsDead");
        }
    }
}

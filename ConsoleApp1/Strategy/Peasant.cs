using ConsoleApp1.StategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    class Peasant : IMovableUnit
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

    //class Peasant : MovableUnits
    //{
    //    public int CarryWeight;

    //    public Peasant(string name) : base(name, 30, 0, "Worker", 4)
    //    {
    //        CarryWeight = 100;
    //    }

    //    public void Work()
    //    {
    //        Console.WriteLine($"{name} - {profession} is moving with {speed}. Can carry {CarryWeight} pounds");
    //    }



    //    public void Repare(Buildings building)
    //    {
    //        if (this.Health > 5)
    //        {
    //            building.Wall += this.CarryWeight;
    //            Console.WriteLine($"{building.name} has been repared by {this.name} with power {this.CarryWeight}." +
    //                $" Walls are {building.Wall}");
    //        }
    //        else Console.WriteLine($"{building.name} has not been repared by {this.name} " +
    //                $" Walls are {building.Wall}");
    //        }

    //    }
}
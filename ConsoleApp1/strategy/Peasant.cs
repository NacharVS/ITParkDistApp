using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.strategy
{
    public class Peasant : MovableUnits
    {
        public int CarryWeight;
        public int hammer;

        public Peasant(string name) : base(name, 30, 0, "Worker", 4)
        {
            Creation();
            CarryWeight = 100;
            hammer = 20;
        }

        public void Work()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Can carry {CarryWeight} pounds");
        }
        public void repairBuilding(Hospital hospital)
        {
            while (hospital.health < 100)
            {
                hospital.health += hammer;
                Console.WriteLine($"Building restored by {hammer} units");

                if (hospital.health >= 100)
                {
                    Console.WriteLine("Building restored");
                    break;
                }
            }
        }
        public void repairBuilding(WatingTower tower)
        {

        }
        public void destroyBuilding(Hospital hospital)
        {
            while (hospital.health <= 100)
            {
                hospital.health -= hammer;
                Console.WriteLine($"The building is destroyed by {hammer} units");

                if (hospital.health == 0)
                {
                    Console.WriteLine("The building is destroyed ");
                    break;
                }
            }

        }
        public void destroyBuilding(WatingTower tower)
        {
        }
    }
}


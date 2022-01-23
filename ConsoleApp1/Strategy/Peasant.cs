using System;

namespace ConsoleApp1.Strategy
{
    class Peasant : MovableUnits
    {
        public int CarryWeight;

        public Peasant(string name) : base(name, 30, 0, "Worker", 4)
        {
            CarryWeight = 100;
            //_id = "asdfg";
        }

        public void Work()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Can carry {CarryWeight} pounds");
        }

        public void BuildingsRepair(Buildings buildings, Random rnd)
        {

            var currentBuildingHP = buildings.Health;
            if (currentBuildingHP >= 2000)
                Console.WriteLine($"{buildings.name} with full HP");
            else if ((2000- currentBuildingHP) >=50)
            {
                buildings.Health += 50;
                Console.WriteLine($"{name} repair {buildings.name} up to 50 points");
            }
            else
            {
                buildings.Health += (2000 - currentBuildingHP);
                Console.WriteLine($"{name} repair {buildings.name} up to {(2000 - currentBuildingHP)} points");
            }

        }
    }
}

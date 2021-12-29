using System;

namespace ConsoleApp1.Strategy
{
    class Peasant : MovableUnits
    {
        public int CarryWeight;
        private int repair;
        private int buildingMaterials;

        public Peasant(string name) : base(name, 30, 0, "Worker", 4)
        {
            CarryWeight = 100;
            buildingMaterials = 100;
        }

        public void Work()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Can carry {CarryWeight} pounds");
        }

        public void repairsBuilding(WathingTower wathingTower)
        {
            if (buildingMaterials > 0)
            {
                repair = 5;
                if ((0 < wathingTower.health) && (100 > wathingTower.health))
                {
                    buildingMaterials -= 10;
                    wathingTower.health += repair;
                    Console.WriteLine($"{name} repair {wathingTower.name} by {repair} hp. {wathingTower.name} has {wathingTower.health} hp . {name} has {buildingMaterials} building materials.");
                }
                else
                if (wathingTower.health <= 0)
                {
                    Console.WriteLine($"{wathingTower.name} is destroyed.");
                }
                else
                    if (wathingTower.health >= 100)
                {
                    Console.WriteLine($"{wathingTower.name} has max health.");
                }
            }
            else
                if (buildingMaterials <= 0)
            {
                Console.WriteLine($"{name} don't have building materials.");
            }
        }
    }
}

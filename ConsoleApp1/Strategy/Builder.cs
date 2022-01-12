using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Builder : Citizen
    {
        public int constructionSkill;

        public Builder(string name) : base(name, 30, 0, 4)
        {
            constructionSkill = 10;
            profession = "Builder";
        }

        public void Repair(Buildings buildings)
        {
            if ((buildings.wall < buildings.maxWall) && (buildings.wall > 0))
            {
                while (buildings.wall < buildings.maxWall)
                {
                    buildings.GetRepair(constructionSkill);
                }
            }

            else if (buildings.wall == 0)
            {
                Console.WriteLine($"Builder cannot repair, {buildings.name} is destroyed!");
            }
        }
    }
}

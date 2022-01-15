using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Builder : Citizen
    {
        private int _constructionSkill;

        public Builder(string name) : base(name, 30, 0, 4)
        {
            Profession = "Builder";
            _constructionSkill = 10;
        }

        //public void Repair(Buildings buildings)
        //{
        //    if ((buildings.wall > 0))
        //    {
        //        while (buildings.wall < buildings.maxWall)
        //        {
        //            buildings.GetRepair(_constructionSkill);
        //        }
        //    }

        //    else if (buildings.wall == 0)
        //    {
        //        Console.WriteLine($"Builder cannot repair, {buildings.Name} is destroyed!");
        //    }
        //}
    }
}

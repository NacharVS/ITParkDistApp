using System;

namespace ConsoleApp1.Strategy
{
    abstract class Buildings : Unit
    {
        public double wall;
        public double maxWall;
        public double materials;
        public double needMaterials;

        public Buildings(string name, double health, double armor) : base(name, health, armor)
        {
            wall = health;
            maxWall = maxHealth;
        }

        public void GetRepair(int constructionSkill)
        {
            if (materials > constructionSkill)
            {
                if ((wall + constructionSkill) < maxWall)
                {
                    wall += constructionSkill;
                    materials -= constructionSkill;
                }
                else
                {
                    wall = maxWall;
                }

                Console.WriteLine($"{name} is being renovated.");
                Info();
            }

            
            
            
            
            
            
        }


    }
}

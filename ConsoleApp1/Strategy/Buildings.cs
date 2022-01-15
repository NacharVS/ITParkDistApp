using System;

namespace ConsoleApp1.Strategy
{
    abstract class Buildings : Unit
    {
        private double _wall;
        private double _maxWall;
        private double _materials;
        private double _needMaterials;

        public Buildings(string name, double maxHealth, double armor) : base(name, maxHealth, armor)
        {
            _wall = maxHealth;
            _maxWall = maxHealth;
            _needMaterials = 0;
        }

        public double Wall
        {
            get
            {
                _wall = Health;
                return _wall;
            }
            set
            {
                Health = _wall = value;
            }
        }    

        public double MaxWall { get; }

        //public void GetRepair(int constructionSkill)
        //{
        //    if (materials > constructionSkill)
        //    {
        //        if ((wall + constructionSkill) < maxWall)
        //        {
        //            wall += constructionSkill;
        //            materials -= constructionSkill;
        //        }
        //        else
        //        {
        //            wall = maxWall;
        //        }

        //        Console.WriteLine($"{name} is being renovated.");
        //        Info();
        //    }
        //}
    }
}

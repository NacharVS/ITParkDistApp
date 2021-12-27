namespace ConsoleApp1.Strategy
{
    abstract class Buildings : Unit
    {
        public double wall;

        public Buildings(string name, double health, double armor) : base(name, health, armor)
        {
            wall = health;
        }
    }
}

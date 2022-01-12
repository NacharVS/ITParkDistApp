using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Strategy
{
    class Hospital : Buildings
    {
        public Hospital(string name, int health, int armor) : base(name, health, armor)
        {
        }

        public void Cure(MovableUnits person)
        {
            Console.WriteLine($"{person.name} is in hospital {this.name}");
            if (this.wall > 0)
            {
                if (person.health > 0)
                {
                    person.health = 30;
                    Console.WriteLine($"{person.name} has health {person.health}");
                }
                else Console.WriteLine($"{person.name} is dead");
            }
            else Console.WriteLine($"{this.name} needs to be repared");
        }
    }
}
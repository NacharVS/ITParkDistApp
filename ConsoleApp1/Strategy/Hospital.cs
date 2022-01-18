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
            if (this.Wall > 0)
            {
                if (person.Health > 0)
                {
                    person.Health = person._maxHealth;           //выздоравливает по максимуму
                    Console.WriteLine($"{person.name} has health {person.Health}");
                }
                else Console.WriteLine($"{person.name} is dead");
            }
            else Console.WriteLine($"{this.name} needs to be repared");
        }

        public void Cure(Healer person)
        {
            Console.WriteLine($"{person.name} is in hospital {this.name}");
            if (this.Wall > 0)
            {
                if (person.Health > 0)
                {
                    person.Health = person._maxHealth;           //выздоравливает по максимуму
                    person.medicine = person.maxMedicine;       //восполняет запасы лекарств
                    Console.WriteLine($"{person.name} has health {person.Health}");
                }
                else Console.WriteLine($"{person.name} is dead");
            }
            else Console.WriteLine($"{this.name} needs to be repared");
        }
    }
}
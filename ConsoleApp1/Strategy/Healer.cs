using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : MovableUnits
    {
        public int medicine;
        public int maxMedicine;
        private int _stepMedicine;
        private int _minHealth;
        public Healer(string name) : base(name, 30, 0, "medic", 3)
        {
            maxMedicine = 30;
            medicine = maxMedicine;            
            _stepMedicine = 3;
            _minHealth = 5;

        }
        public void Cure(MovableUnits person)
        {
            if (this.health >= _minHealth)              //проверяет, здоров ли сам
            {
                Console.WriteLine($"{person.name} is taking cure by {this.profession} {this.name}");
                if (this.medicine >= _stepMedicine)            //проверяетзапас лекарств
                {
                    if (person.health > 0)
                    {
                        person.health += _stepMedicine;
                        this.medicine -= _stepMedicine;
                        Console.WriteLine($"{person.name} has health {person.health}");
                    }
                    else Console.WriteLine($"{person.name} is dead");
                }
                else Console.WriteLine($"{this.name} needs to restock medicines");
            }
            else
            {
                Console.WriteLine($"{this.profession} {this.name} is ill");     //проверяет, здоров ли сам
                this.health += _stepMedicine;                                   //лечит сначала себя
                this.medicine -= this._stepMedicine;
                Console.WriteLine($"{person.name} is taking cure by {this.profession} {this.name}");
                if (this.medicine >= _stepMedicine)
                {
                    if (person.health > 0)
                    {
                        person.health += _stepMedicine;
                        this.medicine -= _stepMedicine;
                        Console.WriteLine($"{person.name} has health {person.health}");
                    }
                    else Console.WriteLine($"{person.name} is dead");
                }
                else Console.WriteLine($"{this.name} needs to restock medicines");
            }
                

        }
    }
}

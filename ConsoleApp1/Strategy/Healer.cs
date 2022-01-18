using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Healer : MovableUnits
    {
        public double healAmount;


        public int medicine;        //запас лекарств текущий
        public int maxMedicine;     //запас лекарств макс. сразу из госпиталя
        private int _stepMedicine;  //шаг лечения за раз
        private int _minHealth;     //мин здоровье, при котором лечит другого, иначе лечит себя

        public Healer(string name, double healAmountParam) : base(name, 50, 5, "Healer", 7)
        {
            healAmount = healAmountParam;

            maxMedicine = 30;
            medicine = maxMedicine;
            _stepMedicine = 3;
            _minHealth = 5;
        }

        public void Heal(MovableUnits unit)
        {
            if (unit.Health + healAmount >= unit._maxHealth)
            {
                unit.Health = unit._maxHealth;
            }
            else
                unit.Health += healAmount;
        }


        public void Cure(MovableUnits person)
        {
            if (this.Health >= _minHealth)              //проверяет, здоров ли сам
            {
                Console.WriteLine($"{person.name} is taking cure by {this.profession} {this.name}");
                if (this.medicine >= _stepMedicine)            //проверяет запас лекарств
                {
                    if (person.Health > 0)
                    {
                        person.Health += _stepMedicine;
                        this.medicine -= _stepMedicine;
                        Console.WriteLine($"{person.name} has health {person.Health}");
                    }
                    else Console.WriteLine($"{person.name} is dead");
                }
                else Console.WriteLine($"{this.name} needs to restock medicines");
            }
            else
            {
                Console.WriteLine($"{this.profession} {this.name} is ill");     //проверяет, здоров ли сам
                this.Health += _stepMedicine;                                   //лечит сначала себя
                this.medicine -= this._stepMedicine;
                Console.WriteLine($"{person.name} is taking cure by {this.profession} {this.name}");
                if (this.medicine >= _stepMedicine)
                {
                    if (person.Health > 0)
                    {
                        person.Health += _stepMedicine;
                        this.medicine -= _stepMedicine;
                        Console.WriteLine($"{person.name} has health {person.Health}");
                    }
                    else Console.WriteLine($"{person.name} is dead");
                }
                else Console.WriteLine($"{this.name} needs to restock medicines");
            }
                

        }
    }
}

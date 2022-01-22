using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                //Врач
    class Healer :MovableUnits
    {
        public double healAmount;  /* переменная коэфицент здоровья*/
        public Healer(string name, double healAmountParam) : base(name, 50, 5, "Врач", 7)   /*Конструктор*/
        {
            healAmount = healAmountParam; /* Сила исциления*/
        }

        public void Heal(MovableUnits unit)        /* Метод лечения*/    /*Передаем экзимпляр MovableUnits*/
        {

            Console.WriteLine($"{profession} {name} вылечил {unit.name}a.");
            if (unit.Healt + healAmount >= _maxHealth)
            {
                unit.Healt = _maxHealth;
            }
            else
            {
                unit.Healt += healAmount;
            }

        }
    }
}

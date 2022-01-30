using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                          //ЛУЧНИК
    class Archer : BattleUnits
    {
        private int _arrows;   /* Количество стрел у лучника*/
        private int _minRangeDamage;      /* минимальный урон на расстоянии*/
        private int _maxRangeDamage;      /*максимальный урон на растоянии*/

        public Archer(string name) : base(name, 45, 0, "Лучник", 7, 1, 2)  /*Конструктор лучника*/
        {
            _arrows = 5;
            _minRangeDamage = 4;            /*минимальный наносимый урон*/
            _maxRangeDamage = 12;           /*максимальный наносимый урон*/

        }
        public double RangeAttack(Random rnd)  /*Метод атаки на крестьянина*/
        {

            if (_arrows > 0)
            {
                double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
                return currentDamage;
            }
            else
            {
                Console.WriteLine($"У лучника {name} закончились стрелы");

                return MleeAttack(rnd);

            }
        }
    }
}

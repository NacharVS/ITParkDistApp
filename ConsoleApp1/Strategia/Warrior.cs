using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    class Warrior : BattleUnit
    {
        private bool _rage = false;   /*Ярость война*/

        public Warrior(string name) : base(name, 90, 10, 5, "Solider",2, 8)  /*Конструктор для война*/
        {
        }

        public override double MleeAttack(Random rnd)
        {


            if (Health > 0.4 * _maxHealt && _rage == false)
            {
                return base.MleeAttack(rnd);
            }
            else
            {
                _rage = true;
                Console.WriteLine($"{name} в ярости");
                return base.MleeAttack(rnd) * 2;
            }
        }
    }
}


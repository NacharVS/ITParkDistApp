using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Стратегия
{
    class Peasant : MovadelUnits  //Рабочий крестьянин 
    {
        public int CarryWeiht;


        public Peasant(string name) : base(name, 30, 0, 4, "Worker")
        {
            CarryWeiht = 100;
        }

        public void Work()
        {
            Console.WriteLine($"{name} - {profession} is moving with {speed}. Can arry {CarryWeiht} pounds");
        }
    }
}

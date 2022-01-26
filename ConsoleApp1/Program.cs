using ConsoleApp1.Strategia;
using ConsoleApp1.Стратегия;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Warrior war = new Warrior("Ivan");
            Archer archer = new Archer("Albertto");
            Battle.Fite(archer, war);
            



        }
    }
}

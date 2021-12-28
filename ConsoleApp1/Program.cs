using ConsoleApp1.strategy;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {


        static void Main(string[] args)
        {
            Random rnd = new Random();
            Peasant peasant1 = new Peasant("Ivan");
            Soldier soldier = new Soldier("Rodion");
            Archer archer = new Archer("Legolas");
            Healer healer = new Healer("Rafal");
            Hospital hospital = new Hospital("Hospital");

            soldier.Move();
            soldier.Attack(peasant1, rnd);
            peasant1.Info();
            peasant1.Move();
            hospital.Treatment(peasant1);
            Console.WriteLine();
            archer.RangeAttack(peasant1, rnd);
            peasant1.Info();
            healer.Healing(peasant1,rnd);
            peasant1.Info();
            Console.WriteLine();
            peasant1.Move();
            peasant1.destroyBuilding(hospital);
            hospital.Info();
            peasant1.repairBuilding(hospital);
            hospital.Info();  
           
        }

    }

}
  

   
    


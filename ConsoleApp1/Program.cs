using ConsoleApp1.InterfacesLab;
using ConsoleApp1.Strategy;
using ConsoleApp1.StrategyInterfaces;
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
           
            Console.WriteLine("-------------------------------------StrategyInterface---------------------------------------");

            Machinegun machinegun = new Machinegun(10,30);
            //Shotgun shotgun = new Shotgun();
            //Pistol pistol = new Pistol();
            //Knife knife = new Knife();

            Gunslinger Bob = new Gunslinger();
            //Bob.PickUpItem(machinegun);
            //Bob.PickUpItem(shotgun);
            //Bob.PickUpItem(pistol);
            //Bob.FireFromAllWeapons();

            Mechanic Igor = new Mechanic();
            //Igor.UpgradeDamage(machinegun);
            //Bob.FireFromAllWeapons();
            //Bob.pocket = knife;
            //Bob.HitByKnife();
            //Igor.UpgradeDamage(knife);

            Bob.Fire(machinegun);
            machinegun.ShowInfo();
            Bob.MultyFire(machinegun);
            Bob.MultyFire(machinegun);
            Bob.MultyFire(machinegun);
            Bob.MultyFire(machinegun);
            Bob.MultyFire(machinegun);
            machinegun.ShowInfo();
            Igor.Repair(machinegun);
            machinegun.ShowInfo();
            Igor.UpgradeDamage(machinegun);
            Bob.MultyFire(machinegun);
       





        }
    }
}

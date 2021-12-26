﻿using System;

namespace ConsoleApp1.Strategy
{
    abstract class Unit
    {
        public string name;
        public double health;
        public int armor;

        protected Unit(string name, int health, int armor)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            Creation();
        }

        public void Creation()
        {
            Console.WriteLine($"{name} is created");
        }

        public void Termination()
        {
            Console.WriteLine($"{name} is terminated");
        }

        public void Info()
        {
            Console.WriteLine($"{name} {health}");
        }
    }
}

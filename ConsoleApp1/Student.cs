using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string name;
        public int age;
        public static string colledgeName = "It Academy";
        public void Studing()
        {
            Console.WriteLine($"Student {name} is studing in {colledgeName}");
        }
    }
}

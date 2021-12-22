using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library
    {
        static void Multiplicationtable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        public static string GetDataQuestionST(string question)
        {
            Console.WriteLine();
            Console.WriteLine(question);
            return Console.ReadLine().ToLower();
        }

        public static int GetDataQuestionIN(string question)
        {
            Console.WriteLine();
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        public static int GetSize(string inquiry)
        {
            Console.WriteLine(inquiry);
            return int.Parse(Console.ReadLine());
        }
    }
}

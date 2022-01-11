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


            List<string> products = new List<string>() { "Beear", "Vodka", "Seledka" };
            List<double> prices = new List<double>() { 100, 450, 250 };
            List<string> currency_name = new List<string>() { "Р", "Р", "Р" };
            Console.WriteLine();
            Console.Write("Client and Admin:");
            string s = Console.ReadLine();
           
            if (s == "Client")
            {
                while (true)
                {
                    Console.WriteLine("Enter the amount of money");
                    double money = 2500;
                    Console.WriteLine("Spicok");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i]} {prices[i]} {currency_name[i]}");

                    }
                    Console.WriteLine("make your choice(ot 1 do 3)");
                }
                
            }


            else
            {
                if(s == "Admin")
                {
                    Console.WriteLine("Admin");

                }
                else
                {
                    Console.WriteLine("Error entered incorrectly");
                }
            }
            

            /*ДЗ №2 задание 2

            Console.Write("Введите число");

            int num = int.Parse(Console.ReadLine());


            while (num > 1 && num % 2 == 0)
            {
                Console.WriteLine(2);
                num = num / 2;
            }

            int a = 3;
            while (num > 1)
            {
                while (num % a == 0)
                {
                    Console.WriteLine(a);
                    num = num / a;
                }
                a = a + 2;
            }*/

            /*ДЗ №2 задание 1

            int sum = int.Parse(Console.ReadLine());
            int combin = 0;
            for (int i = 0; i <= 9; i++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (int l = 0; l <= 9; l++)
                    {
                        if (i + k + l == sum && i != k && k != l && i != l)
                        {
                            Console.WriteLine($"{i}{k}{l}");
                            combin++;
                        }
                    }
                }
            }
            Console.WriteLine("Комбинаций=" + combin);
            */

            /*ДЗ №2 задание 1

            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int maxsum = 0;
            for (int i = 1; i <=n; i++)
            {
                int a = i;
                int sum = 0;
                while (a>0)
                {
                    sum += a % 10;

                    a = a / 10;
                }
                if (maxsum < sum)
                {
                    maxsum = sum;
                    max = i;
                }*/
        }
        }
    }

    


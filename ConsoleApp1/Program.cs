using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
}
    


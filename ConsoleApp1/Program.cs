using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Задача №1
            Console.WriteLine("Введите число");
            int sum = int.Parse(Console.ReadLine());
            int combin = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    for (int l = 0; l < 9; l++)
                    {
                        if (i + k + l == sum && i != k && k != l && i != l && i<k && k<l &&i<l)
                        {
                            Console.WriteLine($"{i}{k}{l}");
                            combin++;
                        }
                    }
                }
            }
            Console.WriteLine("Комбинаций=" + combin);

            //---------------------------------------------------------------------------------------
            //Задача № 3

            //int n = int.Parse(Console.ReadLine());
            //int max = 0;
            //int maxsum = 0;
            //for (int i = 1; i <=n; i++)
            //{
            //    int a = i;
            //    int sum = 0;
            //    while (a>0)
            //    {
            //        sum += a % 10;

            //        a = a / 10;
            //    }
            //    if (maxsum < sum)
            //    {
            //        maxsum = sum;
            //        max = i;
            //    }
            //}

            //Console.WriteLine($"Число{max}сумма {maxsum}");

            //-------------------------------------------------------------------------------------------------

            //Задача №2






        }






    }
    
}

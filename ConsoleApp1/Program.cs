using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {    //Задание № 1.
             //double a, b,c;
             //Console.WriteLine("Введите число 1");
             //a = double.Parse(Console.ReadLine());


            //Console.WriteLine("Введите число 2");
            //b = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите  число 3");
            //c = double.Parse(Console.ReadLine());

            //double result = (a + b + c)/ 3;
            //Console.WriteLine(result);

            //Задание № 2.

            int a;
            //int b;
            //int c;
            //int result;
            //int d;
            //int f;
            Console.WriteLine("Введите трехзначное число");
            a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
             //result = a;
            



            if (a %2==0)
            {
                Console.WriteLine("Вы ввели четное число");
                //d = a;
                
                Console.WriteLine("Cумма трех чисел = ");


            }
            else
            {
                Console.WriteLine("Число не четное");
                //f = a;
                Console.WriteLine("Произведение = ");
            }




        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ��� ����������� �����:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b & a > c)
                Console.WriteLine("������� �����:" +c);
            else
                if (b > a & b < c)
                Console.WriteLine("������� �����:" +b);
            else
                if (c > b & c < a)
                Console.WriteLine("������� �����:" +c);
            //


                





        }
    }
}
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            int _a = int.Parse(Console.ReadLine());
            int _b = int.Parse(Console.ReadLine());
            int _c = int.Parse(Console.ReadLine());

            
            int _result = _a;

            if ((_a < _b && _b < _c) || (_a > _b && _b > _c))
            {
                _result = _b;
            }
            else if ((_b < _c && _c < _a) || (_b > _c && _c > _a))
            {
                _result = _c;
            }
            Console.WriteLine($"Среднее число   {_result}");
        }
    }
}

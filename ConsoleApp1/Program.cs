using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double R, C, S1, S2, V;

            Console.Write("Введите радиус окружности: ");
            R = Convert.ToDouble(Console.ReadLine());
            C = Math.PI * R * 2;
            S1 = Math.PI * Math.Pow(R, 2);
            S2 = 4 * S1;
            V = 4 * Math.PI * Math.Pow(R, 3) / 3;

            Console.WriteLine("\nДлина окружности равна: {0};\nПлощадь круга равна: {1};\nПлощадь поверхности сферы равна: {2};\nОбъём сферы равен: {3}.\n", C, S1, S2, V);
            Console.WriteLine("Нажмите любую клавишу для завершения.");
            Console.ReadKey();
        }
        
    }
}

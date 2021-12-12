using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int summ = int.Parse(Console.ReadLine());
            int combination = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i + j + k == summ && i != j && j != k && i != k)

                        {
                            if (i < j && j < k)

                                Console.WriteLine($"{i}{j}{k}");
                            combination++;
                        }
                    }
                }
            }
            Console.WriteLine($"combination: {combination}");


            Console.ReadLine();

            //Ввывести представление числа N в виде простых множителей. 
            // input 6 output 2 3 // intput 30 output 2 3 5 // input 16 output 2 2 2 2


            Console.WriteLine("insert the number: ");
            int num = int.Parse(Console.ReadLine());

            for (int x = 2; x <= num; x++)
            {
                while (num % x == 0)
                {
                    num = num / x;
                    Console.Write(x);
                    
                }
            }
           
        }
    }
}
  

   
    


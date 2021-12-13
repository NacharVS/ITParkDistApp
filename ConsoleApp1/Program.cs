using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
          while (number > 1 && number%2==0)
            {
                Console.WriteLine(2);
                number= number/2;
            }
            
                int i = 3;
                while (number>1)
            {
                while (number%i==0)
                {
                    Console.WriteLine(i);
                    number= number/i;
                }
                i = i + 2;
            }
            
        }

            
        
    }


}
   

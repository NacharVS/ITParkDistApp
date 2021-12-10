using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entering the sum of three numbers.
            Console.WriteLine("Enter the sum of numbers in the range from 3 to 24:");
            int summ = int.Parse(Console.ReadLine());
            
            int combinationCount = 0;// 2 (0, 1, 2) < summ < 25 (7, 8, 9).

            //Checking a summ is in the correct range.
            if (summ > 2 && summ < 25)
            {
                //Matching small numbers in combination.
                for (int i = 0; i <= 9; i++)
                {
                    //Matching averages numbers in combination
                    for (int j = 0; j <= 9; j++)
                    {
                        //Matching larges numbers in combination.
                        for (int k = 0; k <= 9; k++)
                        {
                            //Selection condition for a combination of three digits.
                            if (i + j + k == summ && i < j && j < k)
                            {
                                
                                Console.WriteLine($"{i}{j}{k}");
                                
                                combinationCount++;
                            }
                        }
                    }
                }
            }

            else Console.WriteLine("You entered the wrong number. The number must be between 3 and 24!");

            Console.WriteLine($" count {combinationCount}");
        }


    }
}

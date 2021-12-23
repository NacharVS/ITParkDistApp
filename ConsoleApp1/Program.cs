using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            ArrayOperations.ArrayGeneration(matrix);
            
            SummID[] summIDs = new SummID[10];
            for (int i = 0; i < summIDs.Length; i++)
            {
                summIDs[i] = new SummID();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Homework_6_1
    {
        public static void Homework6_1()
        {
            int[,] array = new int[10, 10];
            ArrayOperations.ArrayGeneration(array, 10);

            SummID[] summId = new SummID[array.GetLength(0)];

            for (int i = 0; i < summId.Length; i++)
            {
                summId[i] = new SummID();
            }

            ArrayOperations.ArrayRowSumm(array, summId);

            SummID.PrintArraySummID(summId);

            SummID.ArraySummIDSorting(summId);

            SummID.PrintArraySummID(summId);
        }
    }
}

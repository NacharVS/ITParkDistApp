using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SummID
    {
        public int rowId;
        public int summInRow;

        public static void ArraySummIDSorting(SummID[] summIDs)
        {
            for (int j = 0; j < summIDs.Length - 1; j++)
            {
                for (int i = 0; i < summIDs.Length - 1 - j; i++)
                {
                    if (summIDs[i].summInRow > summIDs[i + 1].summInRow)
                    {
                        int bufferSummInRow = summIDs[i + 1].summInRow;
                        summIDs[i + 1].summInRow = summIDs[i].summInRow;
                        summIDs[i].summInRow = bufferSummInRow;
                    }
                }
            }
        }

        public static void ArraySummIDSorting(SummID[] summIDs, bool flag)
        {
            if (flag)
            {
                for (int j = 0; j < summIDs.Length - 1; j++)
                {
                    for (int i = 0; i < summIDs.Length - 1 - j; i++)
                    {
                        if (summIDs[i].summInRow > summIDs[i + 1].summInRow)
                        {
                            int bufferSummInRow = summIDs[i + 1].summInRow;
                            int bufferRowId = summIDs[i + 1].rowId;
                            summIDs[i + 1].summInRow = summIDs[i].summInRow;
                            summIDs[i + 1].rowId = summIDs[i].rowId;
                            summIDs[i].summInRow = bufferSummInRow;
                            summIDs[i].rowId = bufferRowId;
                        }
                    }
                }
            }

            else ArraySummIDSorting(summIDs);
        }

        public static void PrintArraySummID(SummID[] summIDs)
        {
            Console.WriteLine();
            for (int i = 0; i < summIDs.Length; i++)
            {
                Console.WriteLine($"{summIDs[i].rowId}\t{summIDs[i].summInRow}");
            }
        }
    }

}



    

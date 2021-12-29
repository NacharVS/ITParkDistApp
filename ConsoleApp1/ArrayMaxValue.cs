using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayMaxValue
    {
		public static double MaxIndex(double[] array)
		{
			if (array.Length == 0)
				Console.WriteLine("-1");
			var max = double.MinValue;
			int index = 0;
			for (int i = array.Length - 1; i >= 0; i--)
				if (array[i] > max)
				{
					max = array[i];
					index = i;
				}
			return max;
			//return index;
		}

	}
}

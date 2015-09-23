using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using CompareClasses;

namespace SortJaggArr
{
    public class SortJaggedArray
    {
        public static void SortArray(ref int[][] arr, ICompare compare)
        {
            if (compare == null || arr == null)
                throw new ArgumentNullException();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare.Compare(arr[i], arr[j]) == -1)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}

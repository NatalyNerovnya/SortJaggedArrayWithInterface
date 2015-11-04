using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggArr
{
    public class SortJaggedArray
    {
        public delegate int CompareDelegate(int[] arr1, int[] arr2);

        public static void SortArray(int[][] arr, IComparer compare)
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

        public static void SortArrayWithDelegat(int[][] arr, CompareDelegate compare)
        {
            SortArray(arr, new Adapter(compare));
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}

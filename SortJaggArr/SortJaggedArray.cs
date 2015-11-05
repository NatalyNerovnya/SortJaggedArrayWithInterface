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

        public static void SortArray(int[][] arr, IComparer comparer)
        {
            if (comparer == null || arr == null)
                throw new ArgumentNullException();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[i], arr[j]) == -1)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public static void SortArray(int[][] arr, CompareDelegate compare)
        {
            if (compare == null || arr == null)
                throw new ArgumentNullException();
            SortArray(arr, new Adapter(compare));
        }

        private class Adapter : IComparer
        {

            private CompareDelegate comparer;

            public Adapter(CompareDelegate comparer)
            {
                this.comparer = comparer;
            }

            public int Compare(int[] arr1, int[] arr2)
            {
                return comparer(arr1, arr2);
            }

        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            if(a == null || b == null)
                throw new ArgumentNullException();
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}

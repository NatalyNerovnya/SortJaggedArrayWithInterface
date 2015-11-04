using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggArr
{
    class Adapter : IComparer
    {
        
        public SortJaggedArray.CompareDelegate Del;


        public Adapter(SortJaggedArray.CompareDelegate compare)
        {
            Del = new SortJaggedArray.CompareDelegate(compare);
        }


        public int Compare(int[] arr1, int[] arr2)
        {
            return Compare(arr1, arr2, Del);
        }

        private static int Compare(int[] arr1, int[] arr2, SortJaggedArray.CompareDelegate compareDelegate)
        {
            return compareDelegate(arr1, arr2);
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace CompareClasses
{
    class CompareByMaxValue : ICompare
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();

            if (arr1.Max() > arr2.Max())
                return 1;
            else if (arr1.Max() < arr2.Max())
                return -1;
            else
                return 0;
        }
    }
}

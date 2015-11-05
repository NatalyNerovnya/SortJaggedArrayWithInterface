using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortJaggArr;
using CompareClasses;

namespace SortMatrixTests
{
    [TestClass]
    public class SortJaggedArrayTests
    {

        [TestMethod]
        public void SortArray_PositiveArrayAndCompareBySum_SortedArrayAccordingToTheSum()
        {
            CompareBySumDecrease compare = new CompareBySumDecrease();
            int row = 3;
            int[][] jagArr = new int[row][];
            jagArr[0] = new int[] { 6, 3, 2 };
            jagArr[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            jagArr[2] = new int[] { 6, 3, 4 };

            int[][] resultArray = new int[row][];
            resultArray[0] = new int[] { 3, 5, 2, 0, 6, 1 };
            resultArray[1] = new int[] { 6, 3, 4 };
            resultArray[2] = new int[] { 6, 3, 2 };

            SortJaggedArray.SortArray(jagArr, compare);
            
            CollectionAssert.AreEqual(jagArr[0], resultArray[0]);
            CollectionAssert.AreEqual(jagArr[1], resultArray[1]);
            CollectionAssert.AreEqual(jagArr[2], resultArray[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortArray_ArrayAndNull_ArgumentNullException()
        {
            int row = 3;
            int[][] arr = new int [row][];
            arr[0] = new int[] { 6, 3, 2 };
            arr[1] = new int[] { 3, 5, 2, 0, 6, 1 };


            SortJaggedArray.SortArray(arr, (IComparer)null);
        }


        [TestMethod]
        public void SortArray_PositiveArrayAndCompareBySumWithDelegate_SortedArrayAccordingToTheSum()
        {
            CompareBySumDecrease compareInterface = new CompareBySumDecrease();
            SortJaggedArray.CompareDelegate compare = compareInterface.Compare;
            int row = 3;
            int[][] jagArr = new int[row][];
            jagArr[0] = new int[] { 6, 3, 2 };
            jagArr[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            jagArr[2] = new int[] { 6, 3, 4 };

            int[][] resultArray = new int[row][];
            resultArray[0] = new int[] { 3, 5, 2, 0, 6, 1 };
            resultArray[1] = new int[] { 6, 3, 4 };
            resultArray[2] = new int[] { 6, 3, 2 };

            SortJaggedArray.SortArray(jagArr, compare);

            CollectionAssert.AreEqual(jagArr[0], resultArray[0]);
            CollectionAssert.AreEqual(jagArr[1], resultArray[1]);
            CollectionAssert.AreEqual(jagArr[2], resultArray[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortArray_ArrayAndNullWithDelegate_ArgumentNullException()
        {
            int row = 3;
            int[][] arr = new int[row][];
            arr[0] = new int[] { 6, 3, 2 };
            arr[1] = new int[] { 3, 5, 2, 0, 6, 1 };


            SortJaggedArray.SortArray(arr, (SortJaggedArray.CompareDelegate)null);
        }
    }
}

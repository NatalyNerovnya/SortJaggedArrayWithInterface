using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortJaggArr;
using CompareClasses;

namespace SortMatrixTests
{
    [TestClass]
    public class ComparerClassesTests
    {
        [TestMethod]
        public void CompareBySum_BigArraySmallArray_MinusOne()
        {
            int[] arr1 = { 1, 2, 3};
            int[] arr2 = { 3, 4, 5 };
            CompareBySumDecrease compare = new CompareBySumDecrease();

            int result = compare.Compare(arr1, arr2);
            int expectedResult = -1;

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareBySum_NullAndNull_ArgumentNullException()
        {
            CompareBySumDecrease compare = new CompareBySumDecrease();
            compare.Compare(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void CompareBySum_MaxIntegerAndArray_OverflowException()
        {
            CompareBySumDecrease compare = new CompareBySumDecrease();
            int[] arr1 = { int.MaxValue };
            int[] arr2 = { 1, 2, 3 };
            compare.Compare(arr1, arr2);
        }
    }
}

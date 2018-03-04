using DataStructuresAndAlgorithm.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlgorithmUnitTest.Arrays
{
    [TestClass]
    public class SearchInSortedRotatedArrayTests
    {
        [TestMethod]
        public void SearchInSortedRotatedArrayTestMethod1()
        {
            var input = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };

            //-ve Test Case
            Assert.AreEqual(-1, SearchInSortedRotatedArray.GetElementIndex(input, 100));

            //+ve Test Case
            Assert.AreEqual(3, SearchInSortedRotatedArray.GetElementIndex(input, 8));
            Assert.AreEqual(8, SearchInSortedRotatedArray.GetElementIndex(input, 3));
            Assert.AreEqual(4, SearchInSortedRotatedArray.GetElementIndex(input, 9));

            //null Test Case
            Assert.AreEqual(-1, SearchInSortedRotatedArray.GetElementIndex(null, 9));
        }
    }
}

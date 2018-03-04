using DataStructuresAndAlgorithm.Arrays;
using DataStructuresAndAlgorithm.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlgorithmUnitTest.Arrays
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearchTestMethod()
        {
            int[] input = { 1, 3, 7, 9, 10, 15, 20 };

            //-ve Test Case
            Assert.AreEqual(-1,BinarySearch.GetElementIndex(input, 5));

            //+ve Test Case
            Assert.AreEqual(3, BinarySearch.GetElementIndex(input, 9));

            //null Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndex(null, 9));
        }

        [TestMethod]
        public void BinarySearchTestMethod2()
        {
            int[] input = {-5, -2, 1, 3, 7, 9, 10, 15, 20 };

            //-ve Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndex(input, 5));

            //+ve Test Case
            Assert.AreEqual(5, BinarySearch.GetElementIndex(input, 9));

            //null Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndex(null, 9));
        }

        [TestMethod]
        public void BinarySearchTestMetho3()
        {
            int[] input = { 1, 3, 7, 9, 10, 15, 20 };

            //-ve Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndexRecursively(input, 5));

            //+ve Test Case
            Assert.AreEqual(3, BinarySearch.GetElementIndexRecursively(input, 9));

            //null Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndexRecursively(null, 9));
        }

        [TestMethod]
        public void BinarySearchTestMethod4()
        {
            int[] input = { -5, -2, 1, 3, 7, 9, 10, 15, 20 };

            //-ve Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndexRecursively(input, 5));

            //+ve Test Case
            Assert.AreEqual(5, BinarySearch.GetElementIndexRecursively(input, 9));

            //null Test Case
            Assert.AreEqual(-1, BinarySearch.GetElementIndexRecursively(null, 9));
        }
    }
}

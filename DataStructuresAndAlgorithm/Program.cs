using System;
using DataStructuresAndAlgorithm.BinaryTrees;
using DataStructuresAndAlgorithm.LinkedLists;
using DataStructuresAndAlgorithm.Arrays;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static void Main()
        {

            //Arrays
            ArrayHelpers.ArrayProblems();

            //Linked List
            LinkedListHelper.LinkedListProblems();

            // Binary Tree
            BinaryTreeHelper.BinaryTreeProblems();

            // Matrix
            DataStructuresAndAlgorithm.Matrix.MatrixHelpers.MatrixProblems();

            // Math And Stats
            DataStructuresAndAlgorithm.MathAndStats.MathAndStatsHelpers.MathAndStatsProblems();

            Console.ReadKey();
        }

       
    }
}

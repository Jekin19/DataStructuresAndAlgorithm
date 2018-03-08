using System;
using DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves;

namespace DataStructuresAndAlgorithm.Matrix
{
    public class MatrixHelpers
    {
        public static void MatrixProblems()
        {
            //var input = new int[3, 4] { { 2, 4, 9, 13 }, { 3, 5, 11, 18 }, { 6, 8, 16, 21 } };
            //MakeColumnAndRowZeros.MakeZero(input, 16);

            var input = new [,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {-1, 0, -1}};
            //var input = new[,] { { 1, 2, 3, 4 }, {  5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            //Console.WriteLine(new Knight(input).FindNumberOfPaths(2,2));
            //Console.WriteLine(new Rook(input).FindNumberOfPaths(5,2));
            //Console.WriteLine(new Bishop(input).FindNumberOfPaths(2, 2));
            //Console.WriteLine(new King(input).FindNumberOfPaths(7, 3));
            Console.WriteLine(new Queen(input).FindNumberOfPaths(5, 11));
            //Console.WriteLine(new Queen(input).FindNumberOfPaths(2, 3));
        }
    }
}

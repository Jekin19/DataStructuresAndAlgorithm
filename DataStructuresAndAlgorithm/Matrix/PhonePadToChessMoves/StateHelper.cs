using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public static class StateHelper
    {
        public static HashSet<int> GetState(this IBishop bishop, int row, int col, int rowSize, int colSize, int [,] phoneMatrix)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 1; i < rowSize; i++)
            {
                // 1 to 5 
                CheckAndAdd(set, row + i, col + i, rowSize, colSize, phoneMatrix);
                // 5 to 7
                CheckAndAdd(set, row + i, col - i, rowSize, colSize, phoneMatrix);

                // 5 to 1
                CheckAndAdd(set, row - i, col - i, rowSize, colSize, phoneMatrix);
                // 5 to 1 and 9 to 1
                CheckAndAdd(set, row - i, col + i, rowSize, colSize, phoneMatrix);

            }

            return set;
        }

        public static HashSet<int> GetState(this IRook rook, int row, int col, int rowSize, int colSize, int[,] phoneMatrix)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 1; i < rowSize; i++)
            {
                // 2 to 5
                CheckAndAdd(set, row + i, col, rowSize, colSize, phoneMatrix);

                // 5 to 2
                CheckAndAdd(set, row - i, col, rowSize, colSize, phoneMatrix);
            }

            for (int i = 1; i < colSize; i++)
            {
                // 1 to 2
                CheckAndAdd(set, row, col + i, rowSize, colSize, phoneMatrix);

                // 3 to 2
                CheckAndAdd(set, row, col - i, rowSize, colSize, phoneMatrix);

            }

            return set;
        }

        public static void CheckAndAdd(HashSet<int> set, int row, int col, int rowSize, int colSize, int[,] phoneMatrix)
        {
            if (row < rowSize && row >= 0 && col < colSize && col >= 0 && phoneMatrix[row, col] != -1)
            {
                set.Add(phoneMatrix[row, col]);
            }
        }
    }
}

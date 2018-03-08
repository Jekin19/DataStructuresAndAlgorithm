using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public class Pawn : PhoneChessBase, IPhoneNumberFinder
    {
        public Pawn(int[,] phoneMatrix) : base(phoneMatrix) { }

        protected override HashSet<int> GetNextState(int row, int col)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 1; i < RowSize; i++)
            {
                // 5 to 9
                StateHelper.CheckAndAdd(set, row + 1, col + 1, RowSize, ColSize, PhoneMatrix);
                // 5 to 7
                StateHelper.CheckAndAdd(set, row + 1, col - 1, RowSize, ColSize, PhoneMatrix);
                // 5 to 8
                StateHelper.CheckAndAdd(set, row + 1, col, RowSize, ColSize, PhoneMatrix);
            }

            return set;
        }


    }
}

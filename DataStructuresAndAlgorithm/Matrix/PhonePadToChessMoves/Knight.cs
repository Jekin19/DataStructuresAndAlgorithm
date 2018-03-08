using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public class Knight: PhoneChessBase, IPhoneNumberFinder
    {
        public Knight(int[,] phoneMatrix): base(phoneMatrix) { }

        protected override HashSet<int> GetNextState(int row, int col)
        {
            HashSet<int> set = new HashSet<int>();

            // 1 to 6
            StateHelper.CheckAndAdd(set, row - 2, col - 1, RowSize, ColSize, PhoneMatrix);

            // 4 to 9
             StateHelper.CheckAndAdd(set, row + 1, col + 2, RowSize, ColSize, PhoneMatrix);

            // 1 to 8
            StateHelper.CheckAndAdd(set, row + 2, col + 1, RowSize, ColSize, PhoneMatrix);

            // 6 to 7
            StateHelper.CheckAndAdd(set, row + 1, col - 2, RowSize, ColSize, PhoneMatrix);

            // 3 to 4
            StateHelper.CheckAndAdd(set, row - 1, col + 2, RowSize, ColSize, PhoneMatrix);

            // 8 to 3
            StateHelper.CheckAndAdd(set, row + 2, col - 1, RowSize, ColSize, PhoneMatrix); 

            // 7 to 2
            StateHelper.CheckAndAdd(set, row - 2, col + 1, RowSize, ColSize, PhoneMatrix);


            return set;
        }
    }
}

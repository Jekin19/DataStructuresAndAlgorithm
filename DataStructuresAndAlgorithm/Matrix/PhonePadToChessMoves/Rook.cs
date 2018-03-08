using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public class Rook : PhoneChessBase, IPhoneNumberFinder, IRook
    {
        public Rook(int[,] phoneMatrix) : base(phoneMatrix) { }

        protected override HashSet<int> GetNextState(int row, int col)
        {
            return GetState(row, col);
        }

        public HashSet<int> GetState(int row, int col)
        {
            return this.GetState(row, col, RowSize, ColSize, PhoneMatrix);
        }

    }
}

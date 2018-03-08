using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public class Bishop : PhoneChessBase, IPhoneNumberFinder, IBishop
    {
        public Bishop(int[,] phoneMatrix) : base(phoneMatrix) { }

        protected override HashSet<int> GetNextState(int row, int col)
        {
            return GetState(row, col);
        }


        public HashSet<int> GetState( int row, int col)
        {
          return this.GetState(row, col, RowSize, ColSize, PhoneMatrix);
        }
    }
}

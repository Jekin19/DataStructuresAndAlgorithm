using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public class Queen : PhoneChessBase, IPhoneNumberFinder, IBishop, IRook
    {
        public Queen(int[,] phoneMatrix) : base(phoneMatrix) { }

        protected override HashSet<int> GetNextState(int row, int col)
        {
            var bishop = this as IBishop;
            var result = bishop.GetState(row, col);

            var rook = this as IRook;
            result.UnionWith(rook.GetState(row, col, RowSize, ColSize, PhoneMatrix));

            return result;
        }


         HashSet<int> IBishop.GetState(int row, int col)
         {
             var bishop = this as IBishop;
             return bishop.GetState(row, col, RowSize, ColSize, PhoneMatrix);
         }

        HashSet<int> IRook.GetState(int row, int col)
        {
            var rook = this as IRook;
            return rook.GetState(row, col, RowSize, ColSize, PhoneMatrix);
        }
    }
}

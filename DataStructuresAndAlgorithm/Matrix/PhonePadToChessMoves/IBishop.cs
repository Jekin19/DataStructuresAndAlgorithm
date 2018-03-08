using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public interface IBishop
    {
         HashSet<int> GetState(int row, int col);
    }
}

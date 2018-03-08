using System.Collections.Generic;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public interface IRook
    {
        HashSet<int> GetState(int row, int col);
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace DataStructuresAndAlgorithm.Matrix.PhonePadToChessMoves
{
    public abstract class PhoneChessBase
    {
        protected int[,] PhoneMatrix { get; }

        protected int RowSize => PhoneMatrix.GetUpperBound(0)+1;

        protected int ColSize => PhoneMatrix.GetUpperBound(1)+1;

        private readonly ConcurrentDictionary<int, HashSet<int>> _states = new ConcurrentDictionary<int, HashSet<int>>();

        protected PhoneChessBase(int[,] phoneMatrix)
        {
            PhoneMatrix = phoneMatrix;
        }

        /**
         * Returns number of possible paths starting from given digit of size n
         *
         * @param digit Starting digit
         * @param n     Path size
         * @return Number of paths
         */
        public int FindNumberOfPaths(int digit, int n)
        {
            try
            {
              
                Console.WriteLine(DateTime.Now);
                List<Task<int>> taskList = new List<Task<int>>();
                int totalCount = 0;
                for (int i = 0; i < RowSize; i++)
                {
                    for (int j = 0; j < ColSize; j++)
                    {
                        //var task = Task.Factory.StartNew((stateObject) => FindPath((int)(stateObject), n), PhoneMatrix[i, j]);
                        //taskList.Add(task);
                        totalCount = totalCount +FindPath(PhoneMatrix[i, j], n);
                    }
                }

                //Task.WaitAll(taskList.ToArray());

                
                //taskList.ForEach(task => totalCount = totalCount + task.Result);
                Console.WriteLine(DateTime.Now);
                return totalCount;
            }
            catch (Exception exception)
            {
                //log exception
                return -1;
            }
        }

        /**
         * Find number of possible paths starting from given digit of size n
         *
         * @param digit Starting digit
         * @param n     Path size
         * @return Number of paths
         */
        protected int FindPath(int digit, int n)
        {

            if (digit == 0 || digit == 1 || digit == -1 )
            {
                return 0;
            }

            HashSet<Stack<int>> results = new HashSet<Stack<int>>();

            // start the flow from given digit
            Queue<Stack<int>> queue = new Queue<Stack<int>>();
            Stack<int> path = new Stack<int>();
            path.Push(digit);
            queue.Enqueue(path);

            while (queue.Count > 0)
            {
                path = queue.Dequeue();

                if (path.Count == n && !results.Contains(path))
                {
                    results.Add(path);
                    continue;
                }

                int currentPathDigit = path.Peek();
                HashSet<int> states = GetStates(currentPathDigit);
                if (states != null && states.Count > 0)
                {
                    foreach (var state in states)
                    {
                        Stack<int> newPath = new Stack<int>();
                        var temp = path.Reverse();
                        temp.ToList().ForEach(p => newPath.Push(p));
                        newPath.Push(state);
                        queue.Enqueue(newPath);
                    }
                }
            }

            //foreach (var result in results)
            //{
            //    var temp = result.Reverse().ToList();
            //    foreach (var res in temp)
            //    {
            //        Console.Write(res + " ");
            //    }

            //    Console.WriteLine();
            //}

            return results.Count;
        }
        
        /**
         * Returns possible next states for a given digit; use memoization for optimization
         *
         * @param digit Digit
         * @return All possible states
         */
        protected HashSet<int> GetStates(int digit)
        {
            if (_states.ContainsKey(digit))
            {
                return _states[digit];
            }

            int digitRow = -1;
            int digitCol = -1;
            for (int row = 0; digitRow == -1 && row < RowSize; ++row)
            {
                for (int col = 0; digitCol == -1 && col < ColSize; ++col)
                {
                    if (PhoneMatrix[row, col] == digit)
                    {
                        digitRow = row;
                        digitCol = col;
                        break;
                    }
                }
            }

            HashSet<int> nextStates = GetNextState(digitRow, digitCol);
            _states.TryAdd(digit, nextStates);
            return _states[digit];
        }
        
        /**
         * This method returns the possible states for a given digit
         *
         * @param row   Row index for the given digit
         * @param col   Column index for the given digit
         * @return HashSet of possible states
         */
        protected abstract HashSet<int> GetNextState(int row, int col);       

    }
}
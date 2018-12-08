using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestGitDotNet.Interfaces;
using System.Linq;

namespace TestGitDotNet.Implements 
{
    public class ArrayHelper : IArrayHelper
    {

        public int[] GetColumn(int[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public int[] GetRow(int[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

        public int[] GetDiagonalTopLeft(int[,] matrix)
        {
            return new int[] { matrix[0, 0], matrix[1, 1], matrix[2, 2], matrix[3, 3], matrix[4, 4] };
        }

        public int[] GetDiagonalTopRight(int[,] matrix)
        {
            return new int[] { matrix[0, 4], matrix[1, 3], matrix[2, 2], matrix[3, 1], matrix[4, 0] };
        }

        public List<int> GetIndex(int[,] matrix, int number) {
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (matrix[i, y] == number)
                    {
                        return new List<int>(){ i , y};                    
                    }
                    else {
                        continue;
                    }
                    
                }
            }
            return null;
        }
    }
}

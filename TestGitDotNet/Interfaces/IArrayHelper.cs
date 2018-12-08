using System;
using System.Collections.Generic;
using System.Text;

namespace TestGitDotNet.Interfaces
{
    public interface IArrayHelper
    {
        int[] GetColumn(int[,] matrix, int columnNumber);
        int[] GetRow(int[,] matrix, int rowNumber);
        List<int> GetIndex(int[,] matrix, int number);
        int[] GetDiagonalTopLeft(int[,] matrix);
        int[] GetDiagonalTopRight(int[,] matrix);
    }
}

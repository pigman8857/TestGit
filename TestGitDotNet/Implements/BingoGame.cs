using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using TestGitDotNet.Interfaces;

namespace TestGitDotNet.Implements
{
    public class BingoGame : IBingoGame
    {
        //Rows, columns
        private int[,] _bingoBoard;
        private int[,] _calculateBoard;
        private IArrayHelper _arrayHelper;

        public BingoGame(int[,] bingoBoard, IArrayHelper arrayHelper) {
            _bingoBoard = bingoBoard;
            _calculateBoard = (int[,])bingoBoard.Clone();
            _arrayHelper = arrayHelper;
        }


        public void IsBingo(int[] input)
        {
            Console.Write("Input : ");
            for (int i = 0; i < input.Length; i++) {
                Console.Write(input[i] +" ");
            }

            //Check Honrizontal
            for (int rowNumber = 0; rowNumber < 5; rowNumber++)
            {
                int[] row = _arrayHelper.GetRow(_calculateBoard, rowNumber);
                int foundCont = CheckAll(row, input);
                if (foundCont == 5)
                {
                    Console.WriteLine("BINGO!");
                    Console.WriteLine("");
                    return;
                }
            }

            //Check Vertial 
            for (int rowNumber = 0; rowNumber < 5; rowNumber++)
            {
                int[] row = _arrayHelper.GetColumn(_calculateBoard, rowNumber);
                int foundCont = CheckAll(row, input);
                if (foundCont == 5)
                {
                    Console.WriteLine("BINGO!");
                    Console.WriteLine("");
                    return;
                }
            }

            //Check Diogonal    
            int[] diagonalTL = _arrayHelper.GetDiagonalTopLeft(_calculateBoard);
            int foundCont1 = CheckAll(diagonalTL, input);
            if (foundCont1 == 5)
            {
                Console.WriteLine("BINGO!");
                Console.WriteLine("");
                return;
            }

            int[] diagonalTR = _arrayHelper.GetDiagonalTopRight(_calculateBoard);
            int foundCont2 = CheckAll(diagonalTL, input);
            if (foundCont2 == 5)
            {
                Console.WriteLine("BINGO!");
                Console.WriteLine("");
                return;
            }
            Console.WriteLine("");
        }


        private int CheckAll(int[] hNumbers, int[] input) {
            int foundCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int y = 0; y < hNumbers.Length; y++)
                {
                    if (hNumbers[y] == input[i]) {
                        foundCount++;
                    }
                }
            }
            return foundCount;
        }

        private void DisplayIndex(List<int> row, List<int> column)
        {
            for (int i = 0, max = row.Count; i < max; i++)
            {
                Console.WriteLine(row[i] + " , "+column[i]);
            }
        }
    }
}

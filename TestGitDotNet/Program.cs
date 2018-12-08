using System;
using TestGitDotNet.Interfaces;
using TestGitDotNet.Implements;
namespace TestGitDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rows, columns
            int[,] bingoBoard = new int[5, 5] {
                                                { 1, 2, 3, 4, 5 } , 
                                                { 6 , 7, 8 ,9 ,10},
                                                { 11 , 12, 13 ,14 ,15},
                                                { 16 , 17,18 ,19 ,20},
                                                { 21 , 22, 23 ,24 ,25},
                                                };
            int[] input1 = new int[] { 3, 4, 8, 13, 18, 19, 23 };
            int[] input2 = new int[] { 1, 13, 19, 25, 23, 2  };
            int[] input3 = new int[] { 2, 1, 12, 15, 6, 18, 16 ,4 ,3 ,21, 11 };
            int[] input4 = new int[] { 2, 1, 7, 4, 3, 13 ,21, 11, 19 ,25 };
            IArrayHelper arrayHelper = new ArrayHelper();
            IBingoGame bingoGame = new BingoGame(bingoBoard, arrayHelper);
           
            bingoGame.IsBingo(input1);
            bingoGame.IsBingo(input2);
            bingoGame.IsBingo(input3);
            bingoGame.IsBingo(input4);
            Console.ReadKey();
        }
    }
}

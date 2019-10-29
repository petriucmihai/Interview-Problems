using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class GameOfLife
    {
        /*
        Given a board with m by n cells, each cell has an initial state live (1) or dead (0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):

        Any live cell with fewer than two live neighbors dies, as if caused by under-population.
        Any live cell with two or three live neighbors lives on to the next generation.
        Any live cell with more than three live neighbors dies, as if by over-population..
        Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
        Write a function to compute the next state (after one update) of the board given its current state. The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously.

        Example:

        Input: 
        [
          [0,1,0],
          [0,0,1],
          [1,1,1],
          [0,0,0]
        ]
        Output: 
        [
          [0,0,0],
          [1,0,1],
          [0,1,1],
          [0,1,0]
        ]
        */
        public static void GameOfLifeCheck(int[][] board)
        {
            int[][] copyBoard = new int[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                copyBoard[i] = new int[board[i].Length];
                for (int j = 0; j < board[i].Length; j++)
                {
                    copyBoard[i][j] = board[i][j];
                }
            }

            int[] addX = new int[] { 0, 1, 0, -1, 1, 1, -1, -1 };
            int[] addY = new int[] { 1, 0, -1, 0, 1, -1, 1, -1 };

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    int alive = 0; bool currentAlive = copyBoard[i][j] == 1;

                    for (int k = 0; k < addX.Length; k++)
                    {
                        if (CheckBoard(copyBoard, i + addX[k], j + addY[k]))
                        {
                            if (copyBoard[i + addX[k]][j + addY[k]] == 1)
                            {
                                alive++;
                            }
                        }
                    }

                    if (currentAlive)
                    {
                        if (alive < 2)
                        {
                            board[i][j] = 0;
                        }
                        else if (alive == 2 || alive == 3)
                        {
                            board[i][j] = 1;
                        }
                        else
                        {
                            board[i][j] = 0;
                        }
                    }
                    else
                    {
                        if (alive == 3)
                            board[i][j] = 1;
                    }
                }
            }
        }

        private static bool CheckBoard(int[][] board, int i, int j)
        {
            return i < board.Length && i > -1 && j > -1 && j < board[i].Length;
        }
    }
}

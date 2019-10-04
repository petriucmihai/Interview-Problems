using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems
{
    class TicTacToe
    {
        public int[,] board;

        /** Initialize your data structure here. */
        public TicTacToe(int n)
        {
            board = new int[n, n];
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            if (board[row, col] != 0)
            {
                throw new ArgumentException("Cannot move on already played tile");
            }

            int n = board.GetLength(0);

            board[row, col] = player;

            bool isWin = true;
            for (int i = row; i < n; i++)
            {
                if (board[i, col] != player)
                {
                    isWin = false;
                }
            }

            if (isWin)
            {
                for (int i = row; i > 0; i--)
                {
                    if (board[i, col] != player)
                    {
                        isWin = false;
                    }
                }
            }

            if (isWin)
            {
                for (int i = col; i < n; i++)
                {
                    if (board[row, i] != player)
                    {
                        isWin = false;
                    }
                }
            }

            if (isWin)
            {
                for (int i = col; i > 0; i--)
                {
                    if (board[row, i] != player)
                    {
                        isWin = false;
                    }
                }
            }

            if (isWin)
            {
                for (int i = row, j = col; i < n && j < n; i++, j++)
                {
                    if (board[row, col] != player)
                    {
                        isWin = false;
                    }
                }
            }

            if (isWin)
            {
                for (int i = row, j = col; i > 0 && j > 0; i--, j--)
                {
                    if (board[row, col] != player)
                    {
                        isWin = false;
                    }
                }
            }

            if (isWin)
            {
                return player;
            }
            else
            {
                return 0;
            }
        }
    }
}

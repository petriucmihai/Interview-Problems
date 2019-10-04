using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems
{
    class TicTacToe
    {
        private int[,] board;

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

            int count = 0;

            // Check horizontal
            for (int i = row; i < n; i++)
            {
                if (board[i, col] == player)
                {
                    count++;
                }
            }


            for (int i = row - 1; i >= 0; i--)
            {
                if (board[i, col] == player)
                {
                    count++;
                }
            }

            if (count >= n)
            {
                return player;
            }
            else
            {
                count = 0;
            }


            // Check vertical
            for (int i = col; i < n; i++)
            {
                if (board[row, i] == player)
                {
                    count++;
                }
            }

            for (int i = col - 1; i >= 0; i--)
            {
                if (board[row, i] == player)
                {
                    count++;
                }
            }

            if (count >= n)
            {
                return player;
            }
            else
            {
                count = 0;
            }

            // Check diagonal right
            for (int i = row, j = col; i < n && j < n; i++, j++)
            {
                if (board[i, j] == player)
                {
                    count++;
                }
            }

            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == player)
                {
                    count++;
                }
            }

            if (count >= n)
            {
                return player;
            }
            else
            {
                count = 0;
            }

            // Check diagonal left
            for (int i = row, j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == player)
                {
                    count++;
                }
            }

            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i, j] == player)
                {
                    count++;
                }
            }

            if (count >= n)
            {
                return player;
            }

            return 0;
        }

        public void PrintBoard()
        {
            int n = board.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

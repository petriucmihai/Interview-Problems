using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class _8Queens
    {
        int BOARD_SIZE = 8;
        public bool PlaceQueens(int[,] board, int col)
        {
            if (col >= BOARD_SIZE)
            {
                return true;
            }

            for (int i = 0; i < BOARD_SIZE; i++)
            {

                // Check if queen can be placed here according to rules
                if (IsSafe(board, i, col))
                {

                    // Place queen
                    board[i, col] = 1; //board has all zeros when empty

                    // Place rest of Queens using recursion
                    if (PlaceQueens(board, col + 1))
                        return true;

                    // If a placement doesn't work, backtrack
                    board[i, col] = 0;
                }
            }

            // Queen can't be placed
            return false;
        }

        private bool IsSafe(int[,] board, int row, int col)
        {
            int i = 0; int j = 0;

            // Check this row on left size
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                    return false;
            }

            // Check upper diagonal on left side
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            // Check lower diagonal on left side
            for (i = row, j = col; i < BOARD_SIZE && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            return true;
        }
    }
}

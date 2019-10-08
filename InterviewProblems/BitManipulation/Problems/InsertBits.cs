using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.BitManipulation.Problems
{
    class InsertBits
    {
        public static int Insert(int m, int n, int i, int j)
        {
            int numToInsert = n << i;

            // Creates 111000
            int allOnes = ~0;
            int left = allOnes << (j + 1);

            // Creates 00011
            int right = ((1 << i) - 1);

            // OR -- merges them
            int mask = left | right;

            int n_cleared = n & mask;
            int m_shifted = m << i;
            return n_cleared | m_shifted;
        }
    }
}

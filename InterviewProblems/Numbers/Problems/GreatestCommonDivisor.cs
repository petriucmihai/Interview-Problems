using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Numbers.Problems
{
    class GreatestCommonDivisor
    {
        public static int GCD(int a, int b)
        {
            if (a == 0)
                return b;

            return GCD(b % a, a);
        }

        static int MultipleValueGCD(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 1; i < n; i++)
            {
                result = GCD(arr[i], result);

                if (result == 1)
                {
                    return 1;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Numbers.Problems
{
    class ReverseInteger
    {
        public static int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                // Mod 10 takes digit in units place
                int currentDigit = x % 10;
                // Remove rightmost digit
                x = x / 10;

                // Check for overflow: if result * 10 + currentDigit causes overflow, then result >= INTMAX/10. If result > INTMAX/10, overflow will happen.
                // If result == INTMAX/10, result * 10 + currentDigit causes overflow only if currentDigit > 7. Same for negative (-8)
                if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && currentDigit > 7))
                {
                    return 0;
                }
                else if (result < Int32.MinValue / 10 || (result == Int32.MinValue / 10 &&
                                                          currentDigit < -8))
                {
                    return 0;
                }

                result = result * 10 + currentDigit;
            }
            return result;

        }
    }
}

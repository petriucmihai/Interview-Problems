using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Numbers.Problems
{
    class HappyNumber
    {
        /*
            Write an algorithm to determine if a number is "happy".

            A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

                Example: 

                Input: 19
                Output: true
                Explanation: 
                1^2 + 9^2 = 82
                8^2 + 2^2 = 68
                6^2 + 8^2 = 100
                1^2 + 0^2 + 0^2 = 1 
        */

        public static bool IsHappy(int n)
        {
            HashSet<int> nums = new HashSet<int>();
            while (true)
            {
                n = SumOfDigitsSquared(n);
                
                if (n == 1)
                    return true;

                if (nums.Contains(n))
                    return false;

                nums.Add(n);
            }
        }

        public static bool IsHappyConstantSpace(int n)
        {
            // Similar to detecting loop in linked list -- fast pointer and slow pointer
            int slow = SumOfDigitsSquared(n);
            int fast = SumOfDigitsSquared(SumOfDigitsSquared(n));

            while (slow != fast)
            {
                slow = SumOfDigitsSquared(slow);
                fast = SumOfDigitsSquared(SumOfDigitsSquared(fast));
            }

            return (slow == 1);
        }

        private static int SumOfDigitsSquared(int n)
        {
            int result = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                result += (lastDigit * lastDigit);
                n /= 10;
            }

            return result;
        }
    }
}

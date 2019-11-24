using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.BitManipulation.Problems
{
    class AddBinary
    {
        /*
        Given two binary strings, return their sum (also a binary string).

        The input strings are both non-empty and contains only characters 1 or 0.

        Example 1:

        Input: a = "11", b = "1"
        Output: "100"
        Example 2:

        Input: a = "1010", b = "1011"
        Output: "10101"
        */
        public static string AddBinaryAsString(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int iA = a.Length - 1;
            int iB = b.Length - 1;
            int carry = 0;

            while (iA > -1 || iB > -1)
            {
                if (iA >= 0 && a[iA] == '1')
                    carry++;

                if (iB >= 0 && b[iB] == '1')
                    carry++;

                if (carry % 2 == 1)
                {
                    result.Append("1");
                }
                else
                {
                    result.Append("0");
                }

                carry /= 2;

                iA--;
                iB--;
            }

            if (carry > 0)
            {
                result.Append(carry.ToString());
            }

            return ReverseString(result.ToString());
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            return new string(arr);
        }

        /*
        private static string ConvertToBinary(int num)
        {
            StringBuilder resultReversed = new StringBuilder();
            while (num > 0)
            {
                int current = num % 2;
                resultReversed.Append(current.ToString());
                num /= 2;
            }

            char[] arr = resultReversed.ToString().ToCharArray();
            for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            return new string(arr);
        }
        */
    }
}

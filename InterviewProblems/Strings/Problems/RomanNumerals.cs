using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class RomanNumerals
    {
        /*
        Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

        Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.
        Given an integer, convert it to a roman numeral. Input is guaranteed to be within the range from 1 to 3999.

        Example 1:

        Input: 3
        Output: "III"
        Example 2:

        Input: 4
        Output: "IV"
        Example 3:

        Input: 9
        Output: "IX"
        Example 4:

        Input: 58
        Output: "LVIII"
        Explanation: L = 50, V = 5, III = 3.
        Example 5:

        Input: 1994
        Output: "MCMXCIV"
        Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         */
        public static string IntToRoman(int num)
        {
            StringBuilder result = new StringBuilder();
            if (num >= 1000)
            {
                int numberOfM = num / 1000;

                for (int i = 0; i < numberOfM; i++)
                    result.Append("M");

                num = num % 1000;
            }

            if (num >= 500)
            {
                if (num >= 900)
                {
                    result.Append("CM");
                    num = num % 900;
                }
                else
                {
                    result.Append("D");
                    num = num % 500;
                }
            }

            if (num >= 100)
            {
                if (num >= 400)
                {
                    result.Append("CD");
                    num = num % 400;
                }
                else
                {
                    int numberOfC = num / 100;

                    for (int i = 0; i < numberOfC; i++)
                        result.Append("C");

                    num = num % 100;
                }
            }

            if (num >= 50)
            {
                if (num >= 90)
                {
                    result.Append("XC");
                    num = num % 90;
                }
                else
                {
                    result.Append("L");
                    num = num % 50;
                }
            }

            if (num >= 10)
            {
                if (num >= 40)
                {
                    result.Append("XL");
                    num = num % 40;
                }
                else
                {
                    int numberOfX = num / 10;

                    for (int i = 0; i < numberOfX; i++)
                        result.Append("X");

                    num = num % 10;
                }
            }

            if (num >= 5)
            {
                if (num >= 9)
                {
                    result.Append("IX");
                    num = num % 9;
                }
                else
                {
                    result.Append("V");
                    num = num % 5;
                }
            }

            if (num >= 1)
            {
                if (num >= 4)
                {
                    result.Append("IV");
                    num = num % 4;
                }
                else
                {
                    int numberOfI = num;

                    for (int i = 0; i < numberOfI; i++)
                        result.Append("I");

                    num = num % 1;
                }
            }

            return result.ToString();
        }

    }
}

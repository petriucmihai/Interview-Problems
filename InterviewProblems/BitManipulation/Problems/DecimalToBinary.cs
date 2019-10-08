using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.BitManipulation.Problems
{
    class DecimalToBinary
    {
        public static string PrintBinaryBetween0And1(double num)
        {
            if (num >= 1 || num <= 0)
            {
                return "ERROR";
            }

            StringBuilder binaryResult = new StringBuilder();
            binaryResult.Append(".");
            while (num > 0)
            {
                if (binaryResult.Length >= 32)
                {
                    return "ERROR";
                }

                double current = num * 2;
                if (current >= 1)
                {
                    binaryResult.Append("1");
                    num = current - 1;
                }
                else
                {
                    binaryResult.Append(0);
                    num = current;
                }
            }

            return binaryResult.ToString();
        }
    }
}

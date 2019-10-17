using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Permutations.Problems
{
    class GeneratePermutationsOfAString
    {
        public static void PrintPermutations(string input)
        {
            Permute(input, 0, input.Length - 1);
        }

        private static void Permute(string str, int left, int right)
        {
            if (left == right) {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    str = Swap(str, left, i);
                    Permute(str, left + 1, right);
                    str = Swap(str, left, i);
                }
            }
        }

        private static string Swap(string str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }
    }
}

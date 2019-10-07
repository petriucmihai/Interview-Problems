using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Permutations.Problems
{
    class GenerateValidParentheses
    {
        // Generate all sequences and check if each is valid -- 2^2n sequences
        public static List<string> GenerateParenthesisBruteForce(int n)
        {
            List<string> combinations = new List<string>();
            GenerateAll(new char[2 * n], 0, combinations);
            return combinations;
        }

        private static void GenerateAll(char[] current, int pos, List<string> result)
        {
            if (pos == current.Length)
            {
                if (IsValid(current))
                {
                    result.Add(new string(current));
                }
            }
            else
            {
                current[pos] = '(';
                GenerateAll(current, pos + 1, result);
                current[pos] = ')';
                GenerateAll(current, pos + 1, result);
            }
        }

        private static bool IsValid(char[] current)
        {
            int balance = 0;
            foreach (char c in current)
            {
                if (c == '(')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }

                if (balance < 0)
                {
                    return false;
                }
            }

            return balance == 0;
        }

        public static List<string> GenerateParenthesisBacktracking(int n)
        {
            List<string> result = new List<string>();
            Backtrack(result, "", 0, 0, n);
            return result;
        }

        private static void Backtrack(List<string> result, string cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                result.Add(cur);
                return;
            }

            if (open < max)
            {
                Backtrack(result, cur + "(", open + 1, close, max);
            }
            
            if (close < open)
            {
                Backtrack(result, cur + ")", open, close + 1, max);
            }
        }
    }
}

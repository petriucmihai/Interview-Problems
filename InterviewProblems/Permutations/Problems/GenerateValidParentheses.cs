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

        // General Backtracking format
        public static List<string> GenerateValidParenthesesGeneral(int numPairs)
        {
            List<string> result = new List<string>();
            Generate(numPairs, result, "");
            return result;
        }

        private static void Generate(int numPairs, List<string> result, string current)
        {
            

            if (IsValidParentheses(current, numPairs))
            {
                if (current.Length == numPairs * 2)
                {
                    result.Add(current);
                }

                Generate(numPairs, result, current + "(");
                Generate(numPairs, result, current + ")");
            }
        }

        private static bool IsValidParentheses(string paren, int numPairs)
        {
            Stack<char> parenStack = new Stack<char>();
            int leftCount = 0;
            int rightCount = 0;
            for (int i = 0; i < paren.Length; i++)
            {
                if (paren[i] == '(')
                {
                    leftCount++;
                    parenStack.Push('(');
                }
                else
                {
                    rightCount++;
                    if (parenStack.Count() == 0)
                    {
                        return false;
                    }
                    else if (parenStack.Peek() == '(')
                    {
                        parenStack.Pop();
                    }
                }
                if (leftCount > numPairs || leftCount > numPairs)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

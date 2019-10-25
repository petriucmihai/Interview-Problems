using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewProblems.Arrays;
using InterviewProblems.LinkedLists;
using InterviewProblems.ModelingProblems;
using InterviewProblems.Strings;
using InterviewProblems.TreesAndGraphs.Problems;
using InterviewProblems.TreesAndGraphs.UtilityClasses;
using InterviewProblems.Permutations.Problems;
using InterviewProblems.Arrays.Problems;
using InterviewProblems.SearchingAndSorting.Problems;
using InterviewProblems.SearchingAndSorting.SortingAlgorithms;
using InterviewProblems.Strings.Problems;
using InterviewProblems.SearchingAndSorting.SearchAlgorithms;

namespace InterviewProblems
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running interview problems here for testing:");

            /*
            // TicTacToe
            int n = 3;
            Console.WriteLine("Starting TicTacToe with board size: " + n);
            ModelingProblems.TicTacToe game = new TicTacToe(n);
            Console.WriteLine("Game results:");
            Console.WriteLine(game.Move(0, 0, 1));
            game.PrintBoard();
            Console.WriteLine(game.Move(0, 2, 2));
            game.PrintBoard();
            Console.WriteLine(game.Move(2, 2, 1));
            game.PrintBoard();
            Console.WriteLine(game.Move(1, 1, 2));
            game.PrintBoard();
            Console.WriteLine(game.Move(2, 0, 1));
            game.PrintBoard();
            Console.WriteLine(game.Move(1, 0, 2));
            game.PrintBoard();
            Console.WriteLine(game.Move(2, 1, 1));
            game.PrintBoard();

            Console.WriteLine();
            n = 2;
            Console.WriteLine("Starting TicTacToe with board size: " + n);

            ModelingProblems.TicTacToe game2 = new TicTacToe(n);
            Console.WriteLine("Game results:");
            Console.WriteLine(game2.Move(0, 1, 1));
            game2.PrintBoard();
            Console.WriteLine(game2.Move(1, 1, 2));
            game2.PrintBoard();
            Console.WriteLine(game2.Move(1, 0, 1));
            game2.PrintBoard();
            */

            /*
            // ZigZag binary tree traversal
            Console.Write("Starting Tree:");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TreeNode root = CreateBSTFromSortedArray.CreateBST(arr);
            TreePrinter.Print(root);

            Console.WriteLine();

            IList<IList<int>> result = BinaryTreeZigZagTraversal.ZigzagLevelOrder(root);

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine("]");
            }
            */

            /*
            // Generate Valid Parentheses
            int n = 3;
            Console.WriteLine("Valid Parentheses for n =" + n);
            List<string> validParensBF = GenerateValidParentheses.GenerateParenthesisBruteForce(n);
            List<string> validParensBK = GenerateValidParentheses.GenerateParenthesisBacktracking(n);

            Console.WriteLine("Brute Force:");
            foreach (string paren in validParensBF)
            {
                Console.WriteLine(paren);
            }

            Console.WriteLine();

            Console.WriteLine("Backtracking:");
            foreach (string paren in validParensBK)
            {
                Console.WriteLine(paren);
            }
            */

            /*
            // Create Trees from arrays
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TreeNode node = BuildTreeFromArray.BuildCompleteTree(arr);
            TreePrinter.Print(node);
            */

            /*
            // 3-Sum
            int[] array = new int[] { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> result = ThreeSum.Sum(array);

            Console.WriteLine("Result sets:");
            foreach (IList<int> list in result)
            {
                Console.Write("[ ");
                foreach (int num in list)
                {
                    Console.Write(num + ", ");
                }
                Console.WriteLine("]");
            }
            */
            /*
            // Search sorted rotated array
            int[] rotatedArray = new int[] { 1, 3 };//, 5, 6, 7, 0, 1, 2 };

            SearchRotatedArray.Search(rotatedArray, 0);
            */

            /*
            // Rotate square matrix

            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            Console.WriteLine("Before Rotation");
            foreach (int[] row in matrix)
            {
                Console.Write("[ ");
                foreach (int num in row)
                {
                    Console.Write(num + ", ");
                }
                Console.WriteLine("]");
            }


            RotateSquareMatrix.Rotate(matrix);

            Console.WriteLine();

            Console.WriteLine("After Rotation");
            foreach (int[] row in matrix)
            {
                Console.Write("[ ");
                foreach (int num in row)
                {
                    Console.Write(num + ", ");
                }
                Console.WriteLine("]");
            }
            */

            // Reverse Words in String
            //Console.WriteLine(ReverseWordsInString.ReverseWords("a good   example"));

            /*
            // Find Kth largest element in BST
            Console.Write("Starting Tree:");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TreeNode root = BuildBSTFromSortedArray.CreateBST(arr);
            TreePrinter.Print(root);

            Console.WriteLine();

            int k = 2;
            Console.WriteLine(k + "th largest element in tree: " + KthLargestElementInBST.FindKthLargestElementInBST(root, k));
            */

            /*
            // QuickSelect
            int k = 3;
            Console.WriteLine("Find " + k + "th largest element");

            Console.WriteLine();

            int[] arr = new int[] { 3, 2, 1, 5, 6, 4 };
            int[] sortedArr = new int[] { 3, 2, 1, 5, 6, 4 };
            Console.WriteLine("Unsorted Array: ");
            Console.Write("[ ");
            foreach (int num in arr)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("]");

            QuickSort.QuickSortInt(sortedArr);

            Console.WriteLine();

            Console.WriteLine("Sorted Array: ");
            Console.Write("[ ");
            foreach (int num in sortedArr)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("]");

            Console.WriteLine();

            Console.WriteLine(k + "th largest element is: " + QuickSelect.FindKthSmallestElement(arr, arr.Length - k));
            */


            // Suspends console after problems are run
            Console.Read();
        }
    }
}

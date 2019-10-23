using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class CheckBalanced
    {
        public static bool CheckBalancedTreeBasic(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int heightDiff = GetHeight(root.left) - GetHeight(root.right);

            if (heightDiff > 1)
            {
                return false;
            }
            else
            {
                return CheckBalancedTreeBasic(root.left) && CheckBalancedTreeBasic(root.right);
            }
        }

        private static int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return -1;
            }

            return Math.Max(GetHeight(node.left), GetHeight(node.left)) + 1;
        }

        public static bool CheckBalancedTreeOptimized(TreeNode root)
        {
            return CheckHeight(root) != Int32.MinValue;
        }

        private static int CheckHeight(TreeNode node)
        {
            if (node == null)
            {
                return -1;
            }

            int leftHeight = CheckHeight(node.left);
            if (leftHeight == Int32.MinValue)
                return Int32.MinValue;

            int rightHeight = CheckHeight(node.right);
            if (rightHeight == Int32.MinValue)
                return Int32.MinValue;

            int heightDiff = leftHeight - rightHeight;

            if (Math.Abs(heightDiff) > 1)
            {
                return Int32.MinValue;
            }
            else
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }

        }
    }
}

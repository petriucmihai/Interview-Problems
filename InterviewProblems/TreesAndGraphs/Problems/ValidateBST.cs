using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class ValidateBST
    {
        public static bool ValidateBinarySearchTree(TreeNode root)
        {
            return TraverseWithLimits(root, null, null);
        }

        private static bool TraverseWithLimits(TreeNode node, int? min, int? max)
        {
            if (node == null)
            {
                return true;
            }

            if (min != null && node.val <= min)
            {
                return false;
            }

            if (max != null && node.val >= max)
            {
                return false;
            }

            if (!TraverseWithLimits(node.right, node.val, max))
            {
                return false;
            }
            if (!TraverseWithLimits(node.left, min, node.val))
            {
                return false;
            }
            return true;
        }
    }
}

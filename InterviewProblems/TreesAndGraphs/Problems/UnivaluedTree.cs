using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class UnivaluedTree
    {
        public static bool IsUnivalTree(TreeNode root)
        {
            return CheckValue(root, root.val);
        }

        private static bool CheckValue(TreeNode root, int val)
        {
            bool left = true;
            if (root.left != null)
            {
                left = CheckValue(root.left, val);
            }

            bool right = true;
            if (root.right != null)
            {
                right = CheckValue(root.right, val);
            }

            if (left && right)
            {
                return root.val == val;
            }
            else
            {
                return false;
            }
        }
    }
}

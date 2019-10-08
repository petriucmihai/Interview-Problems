using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class IsMirror
    {
        public static bool IsSymmetric(TreeNode root)
        {
            return IsMirrorTree(root, root);
        }

        private static bool IsMirrorTree(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null)
            {
                return true;
            }
            else if (n1 == null || n2 == null)
            {
                return false;
            }

            return (n1.val == n2.val) && IsMirrorTree(n1.right, n2.left) && IsMirrorTree(n1.left, n2.right);
        }

    }
}

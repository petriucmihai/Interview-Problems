using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class IsSameTree
    {
        public static bool IsSameTreeRecursive(TreeNode p, TreeNode q)
        {
            if (p == null & q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            return IsSameTreeRecursive(p.right, q.right) && IsSameTreeRecursive(p.left, q.left);
        }
    }
}

using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class MergeTrees
    {
        public static TreeNode MergeTwoTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }
            if (t2 == null)
            {
                return t1;
            }
            t1.val += t2.val;

            t1.left = MergeTwoTrees(t1.left, t2.left);
            t1.right = MergeTwoTrees(t1.right, t2.right);

            return t1;
        }
    }
}

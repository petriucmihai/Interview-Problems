using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class HeightOfTree
    {
        public static int Height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = Height(root.left);
            int right = Height(root.right);

            return Math.Max(right, left) + 1;
        }
    }
}

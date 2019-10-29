using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class RangeSumBST
    {
        /*
         Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).

        The binary search tree is guaranteed to have unique values.

 

        Example 1:

        Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
        Output: 32
        Example 2:

        Input: root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
        Output: 23
        */

        public static int RangeSumOfBST(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return 0;
            }
            int sum = 0;

            if (root.val <= R && root.val >= L)
            {
                sum += root.val;
            }

            if (root.val >= R)
            {
                sum += RangeSumOfBST(root.left, L, R);
            }
            else if (root.val <= L)
            {
                sum += RangeSumOfBST(root.right, L, R);
            }
            else
            {
                sum += RangeSumOfBST(root.left, L, R);
                sum += RangeSumOfBST(root.right, L, R);
            }

            return sum;
        }
    }
}

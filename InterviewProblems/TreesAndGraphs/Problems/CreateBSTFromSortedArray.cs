using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class CreateBSTFromSortedArray
    {
        public static TreeNode CreateBST(int[] arr)
        {
            return Create(arr, 0, arr.Count() - 1);
        }

        private static TreeNode Create(int[] arr, int left, int right)
        {
            if (right >= left)
            {
                int mid = (right + left) / 2;
                TreeNode newNode = new TreeNode(arr[mid]);
                newNode.left = Create(arr, left, mid - 1);
                newNode.right = Create(arr, mid + 1, right);

                return newNode;
            }

            return null;
        }
    }
}

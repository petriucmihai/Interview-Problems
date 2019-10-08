using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class BuildTreeFromArray
    {
        public static TreeNode BuildCompleteTree(int[] array)
        {
            return BuildInOrder(array, null, 0);
        }

        private static TreeNode BuildInOrder(int[] array, TreeNode node, int index)
        {
            if (index < array.Length)
            {
                node = new TreeNode(array[index]);

                node.left = BuildInOrder(array, node.left, 2 * index + 1);
                node.right = BuildInOrder(array, node.right, 2 * index + 2);

                return node;
            }

            return null;
        }

        //public static TreeNode BuildTreeFromPreorderInorder()
    }
}

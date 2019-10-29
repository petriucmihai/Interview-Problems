using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class BottomUpLevelOrderTraversal
    {
        /*
        Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

        For example:
        Given binary tree [3,9,20,null,null,15,7],
            3
           / \
          9  20
            /  \
           15   7
        return its bottom-up level order traversal as:
        [
          [15,7],
          [9,20],
          [3]
        ]
         */
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            List<TreeNode> current = new List<TreeNode>();

            if (root != null)
            {
                current.Add(root);
                result.Add(new List<int> { root.val });
            }

            while (current.Count() > 0)
            {
                List<TreeNode> parents = current;
                current = new List<TreeNode>();

                foreach (TreeNode node in parents)
                {
                    if (node.left != null)
                    {
                        current.Add(node.left);
                    }
                    if (node.right != null)
                    {
                        current.Add(node.right);
                    }
                }

                if (current.Count() > 0)
                {
                    List<int> addToResult = new List<int>();
                    foreach (TreeNode node in current)
                    {
                        addToResult.Add(node.val);
                    }

                    result.Add(addToResult);
                }


            }

            for (int i = 0, j = result.Count() - 1; i < result.Count() / 2; i++, j--)
            {
                IList<int> temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }

            return result;
        }
    }
}

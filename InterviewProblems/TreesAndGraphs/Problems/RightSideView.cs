using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class RightSideView
    {
        /*
            Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

            Example:

            Input: [1,2,3,null,5,null,4]
            Output: [1, 3, 4]
            Explanation:

               1            <---
             /   \
            2     3         <---
             \     \
              5     4       <---
        */
        public static IList<int> GetRightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            List<TreeNode> current = new List<TreeNode>();

            if (root != null)
            {
                current.Add(root);
                result.Add(root.val);
            }

            while (current.Count > 0)
            {
                List<TreeNode> parents = current;
                current = new List<TreeNode>();

                foreach (TreeNode node in parents)
                {
                    if (node.left != null)
                        current.Add(node.left);

                    if (node.right != null)
                        current.Add(node.right);
                }

                if (current.Count() > 0)
                {
                    result.Add(current[current.Count() - 1].val);
                }
                
            }

            return result;
        }
    }
}

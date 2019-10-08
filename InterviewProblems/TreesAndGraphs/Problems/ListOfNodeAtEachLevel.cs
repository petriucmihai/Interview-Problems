using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class ListOfNodeAtEachLevel
    {
        public static List<List<TreeNode>> ListofLevelsBFS(TreeNode root)
        {
            List<List<TreeNode>> result = new List<List<TreeNode>>();

            // Visit root
            List<TreeNode> current = new List<TreeNode>();
            if (root != null)
                current.Add(root);

            while (current.Count > 0)
            {
                result.Add(current);

                List<TreeNode> parents = current;
                current = new List<TreeNode>();

                foreach (TreeNode parent in parents)
                {
                    if (parent.left != null)
                    {
                        current.Add(parent.left);
                    }
                    if (parent.right != null)
                    {
                        current.Add(parent.right);
                    }
                }
            }
            return result;
        }
    }
}

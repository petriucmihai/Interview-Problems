using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class LowestCommonAncestor
    {
        public static TreeNode LowestCommonAncestorOfTree(TreeNode root, TreeNode p, TreeNode q)
        {
            return LCA(root, p, q);
        }

        private static TreeNode LCA(TreeNode node, TreeNode p, TreeNode q)
        {

            if (node == null)
            {
                return null;
            }

            // If both n1 and n2 are smaller than root, then LCA lies in left  
            if (node.val > p.val && node.val > q.val)
            {
                return LCA(node.left, p, q);
            }

            // If both n1 and n2 are greater than root, then LCA lies in right  
            if (node.val < p.val && node.val < q.val)
            {
                return LCA(node.right, p, q);
            }

            return node;

        }
    }
}

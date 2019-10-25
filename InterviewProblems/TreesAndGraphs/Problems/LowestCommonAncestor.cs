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
        public static TreeNode LowestCommonAncestorOfBST(TreeNode root, TreeNode p, TreeNode q)
        {
            return LCABST(root, p, q);
        }

        private static TreeNode LCABST(TreeNode node, TreeNode p, TreeNode q)
        {

            if (node == null)
            {
                return null;
            }

            // If both n1 and n2 are smaller than root, then LCA lies in left  
            if (node.val > p.val && node.val > q.val)
            {
                return LCABST(node.left, p, q);
            }

            // If both n1 and n2 are greater than root, then LCA lies in right  
            if (node.val < p.val && node.val < q.val)
            {
                return LCABST(node.right, p, q);
            }

            return node;

        }

        public static TreeNode LowestCommonAncestorOfTreeLCAConfirmed(TreeNode node, TreeNode p, TreeNode q)
        {
            // Base case 
            if (node == null)
                return null;

            // If either n1 or n2 matches with root's key, report 
            // the presence by returning root (Note that if a key is 
            // ancestor of other, then the ancestor key becomes LCA 
            if (node == p || node == q)
                return node;

            // Look for keys in left and right subtrees 
            TreeNode leftLCA = LowestCommonAncestorOfTreeLCAConfirmed(node.left, p, q);
            TreeNode rightLCA = LowestCommonAncestorOfTreeLCAConfirmed(node.right, p, q);

            // If both of the above calls return Non-NULL, then one key 
            // is present in once subtree and other is present in other, 
            // So this node is the LCA 
            if (leftLCA != null && rightLCA != null)
            {
                return node;
            }
            else if (leftLCA != null)
            {
                return leftLCA;
            }
            else if (rightLCA != null)
            {
                return rightLCA;
            }
            else
            {
                return null;
            }
        }

        
    }
}

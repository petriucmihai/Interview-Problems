using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class DiameterOfTree
    {
        /*
            Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest 
            path between any two nodes in a tree. This path may or may not pass through the root.
        */
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Diameter(root) - 1;
        }

        private int Diameter(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int lDiameter = Diameter(root.left);
            int rDiameter = Diameter(root.right);

            int lHeight = Height(root.left);
            int rHeight = Height(root.right);

            return Math.Max(1 + lHeight + rHeight, Math.Max(lDiameter, rDiameter));
        }

        private int Height(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(Height(node.right), Height(node.left)) + 1;
        }
    }
}

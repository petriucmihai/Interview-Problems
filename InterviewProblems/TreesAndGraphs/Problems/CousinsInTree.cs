using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class CousinsInTree
    {
        /*
        n a binary tree, the root node is at depth 0, and children of each depth k node are at depth k+1.

        Two nodes of a binary tree are cousins if they have the same depth, but have different parents.

        We are given the root of a binary tree with unique values, and the values x and y of two different nodes in the tree.

        Return true if and only if the nodes corresponding to the values x and y are cousins.
        */
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            List<int> xPath = new List<int>();
            bool isXPath = FindPath(root, x, xPath);

            List<int> yPath = new List<int>();
            bool isYPath = FindPath(root, y, yPath);

            if (isXPath && isYPath)
            {
                if (xPath.Count() == yPath.Count())
                {
                    if (xPath[xPath.Count() - 2] != yPath[yPath.Count() - 2])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool FindPath(TreeNode root, int target, List<int> path)
        {
            if (root == null)
            {
                return false;
            }

            path.Add(root.val);

            if (root.val == target)
            {
                return true;
            }

            if (root.left != null && FindPath(root.left, target, path))
            {
                return true;
            }
            if (root.right != null && FindPath(root.right, target, path))
            {
                return true;
            }

            path.RemoveAt(path.Count() - 1);
            return false;
        }
    }
}

using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class KthLargestElementInBST
    {
        /*
            Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

                Note:
                You may assume k is always valid, 1 ≤ k ≤ BST's total elements.

                Example 1:

                Input: root = [3,1,4,null,2], k = 1
                   3
                  / \
                 1   4
                  \
                   2
                Output: 1
                Example 2:

                Input: root = [5,3,6,2,4,null,null,1], k = 3
                       5
                      / \
                     3   6
                    / \
                   2   4
                  /
                 1
                Output: 3 
        */
        public static int FindKthLargestElementInBST(TreeNode root, int k)
        {
            List<TreeNode> nodeList = ReverseInOrder(root, k, new List<TreeNode>());
            return nodeList[k - 1].val;
        }

        private static List<TreeNode> ReverseInOrder(TreeNode node, int k, List<TreeNode> order)
        {
            // Add nodes to list in reverse inorder traversal order
            if (node == null)
            {
                return order;
            }

            ReverseInOrder(node.right, k, order);

            if (order.Count() >= k)
            {
                return order;
            }

            order.Add(node);

            ReverseInOrder(node.left, k, order);

            return order;
        }
    }
}

using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class LeafOrder
    {
        /*
        Consider all the leaves of a binary tree.  From left to right order, the values of those leaves form a leaf value sequence.

        Two binary trees are considered leaf-similar if their leaf value sequence is the same.

        Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.
         */

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<TreeNode> list1 = new List<TreeNode>();
            CreateLeafList(root1, list1);

            List<TreeNode> list2 = new List<TreeNode>();
            CreateLeafList(root2, list2);

            for (int i = 0; i < list1.Count(); i++)
            {
                if (list1[i].val != list2[i].val)
                    return false;
            }

            return list1.Count() == list2.Count();
        }

        private void CreateLeafList(TreeNode node, List<TreeNode> list)
        {
            if (node != null)
            {
                if (node.left != null)
                    CreateLeafList(node.left, list);

                if (node.left == null && node.right == null)
                    list.Add(node);

                if (node.right != null)
                    CreateLeafList(node.right, list);
            }
        }
    }
}

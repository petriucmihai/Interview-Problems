using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.UtilityClasses
{
    class TreeCreator
    {
        public void Create(TreeNode root, int[] values, int index)
        {
            root.val = values[index];

            if (index * 2 + 1 < values.Length)
            {
                TreeNode node = new TreeNode();
                Create(node, values, index * 2 + 1);
                root.left = node;
            }
            if (index * 2 + 2 < values.Length)
            {
                TreeNode node = new TreeNode();
                Create(node, values, index * 2 + 2);
                root.right = node;
            }
        }
    }
}

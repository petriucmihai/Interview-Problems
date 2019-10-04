using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.UtilityClasses
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.val = val;
        }

        public TreeNode()
        {
            val = 0;
        }

        public List<TreeNode> Children()
        {
            List<TreeNode> result = new List<TreeNode>();
            if (left != null)
            {
                result.Add(left);
            }
            if (right != null)
            {
                result.Add(right);
            }
            return result;
        }
    }
}

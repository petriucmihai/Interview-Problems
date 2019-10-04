using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class BinaryTreeZigZagTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            List<TreeNode> current = new List<TreeNode>();
            List<TreeNode> parents = new List<TreeNode>();
            current.Add(root);

            result.Add(new List<int> { root.val });

            while (current.Count() > 0)
            {
                parents = current;
                current.Clear();

                List<int> levelValues = new List<int>();

                for (int i = 0; i < parents.Count(); i++)
                {
                    current.Add(parents[i].left);
                    levelValues.Add(parents[i].left.val);
                    current.Add(parents[i].right);
                    levelValues.Add(parents[i].right.val);
                }

                if (levelValues.Count() > 0)
                {
                    result.Add(levelValues);
                }
            }

            return result;
        }
    }
}

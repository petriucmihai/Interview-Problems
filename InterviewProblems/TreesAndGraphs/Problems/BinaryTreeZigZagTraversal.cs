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
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            List<TreeNode> current = new List<TreeNode>();
            if (root != null)
            {
                current.Add(root);
                result.Add(new List<int> { root.val });
            }

            bool zigzag = false;

            while (current.Count() > 0)
            {
                List<TreeNode> parents = current;
                current = new List<TreeNode>();

                List<int> levelValues = new List<int>();

                for (int i = 0; i < parents.Count(); i++)
                {
                    if (parents[i].left != null)
                        current.Add(parents[i].left);

                    if (parents[i].right != null)
                        current.Add(parents[i].right);
                }

                if (zigzag)
                {
                    for (int i = 0; i < current.Count(); i++)
                        levelValues.Add(current[i].val);
                }
                else
                {
                    for (int i = current.Count() - 1; i >= 0; i--)
                        levelValues.Add(current[i].val);
                }
                

                if (levelValues.Count() > 0)
                    result.Add(levelValues);

                zigzag = !zigzag;
            }

            return result;
        }
    }
}

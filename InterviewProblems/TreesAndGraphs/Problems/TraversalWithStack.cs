using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class TraversalWithStack
    {
        public static void Inorder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }


            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode curr = root;

            // traverse the tree  
            while (curr != null || s.Count > 0)
            {

                /* Reach the left most Node of the  
                curr Node */
                while (curr != null)
                {
                    /* place pointer to a tree node on  
                       the stack before traversing  
                      the node's left subtree */
                    s.Push(curr);
                    curr = curr.left;
                }

                /* Current must be NULL at this point */
                curr = s.Pop();

                Console.Write(curr.val + " ");

                /* we have visited the node and its  
                   left subtree.  Now, it's right  
                   subtree's turn */
                curr = curr.right;
            }
        }
    }
}

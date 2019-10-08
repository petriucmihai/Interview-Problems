using InterviewProblems.TreesAndGraphs.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.Problems
{
    class IsSubtree
    {
        /*
         Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and node values with a subtree of s. 
         A subtree of s is a tree consists of a node in s and all of this node's descendants. The tree s could also be considered as a subtree of itself.
        */
        public bool IsSubtreeOfTree(TreeNode s, TreeNode t)
        {
            if (s == null)
            {
                return false;
            }

            return Equals(s, t) || IsSubtreeOfTree(s.left, t) || IsSubtreeOfTree(s.right, t);
        }

        public bool Equals(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }
            else if (s == null || t == null)
            {
                return false;
            }
            return s.val == t.val && Equals(s.left, t.left) && Equals(s.right, t.right);
        }

    }
}

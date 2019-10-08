using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class DeleteCurrentNode
    {
        public static bool DeleteCurrentNodeWithoutHead(Node node)
        {
            if (node.next != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
                return true;
            }
            return false;
        }
    }
}

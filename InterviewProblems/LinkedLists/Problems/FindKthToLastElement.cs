using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class FindKthToLastElement
    {
        public static Node KthToLastElement(Node head, int k)
        {
            // 1 means last, 2 means second to last...
            if (head == null)
            {
                return null;
            }

            Node p1 = head;
            Node p2 = head;

            for (int i = 0; i < k; i++)
            {
                if (p2.next == null)
                {
                    return null;
                }
                p2 = p2.next;
            }

            while (p2 != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            return p1;
        }
    }
}

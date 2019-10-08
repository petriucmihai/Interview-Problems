using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class ReverseLinkedListInBatches
    {
        public static Node ReverseListInBatches(Node head, int k)
        {
            Node curr = head;
            Node next = null;
            Node prev = null;

            int count = 0;

            while (count < k && curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                count++;
            }

            if (next != null)
                head.next = ReverseListInBatches(next, k);

            return prev;
        }
    }
}

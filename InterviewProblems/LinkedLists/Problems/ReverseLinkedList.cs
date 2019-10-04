using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class ReverseLinkedList
    {
        public static Node ReverseList(Node head)
        {
            if (head == null)
            {
                return null;
            }
            else if (head.next == null)
            {
                return head;
            }

            Node curr = head;
            Node prev = null;

            while (curr != null)
            {
                Node nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            return prev;
        }
    }
}

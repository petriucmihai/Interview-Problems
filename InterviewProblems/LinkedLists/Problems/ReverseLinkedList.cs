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

        public Node ReverseBetween(Node head, int m, int n)
        {
            if (head == null)
            {
                return null;
            }

            Node curr = head;
            Node prev = null;
            while (m > 1)
            {
                prev = curr;
                curr = curr.next;
                m--;
                n--;
            }

            // The two pointers that will fix the final connections.
            Node con = prev;
            Node tail = curr;

            // Iteratively reverse the nodes until n becomes 0.
            Node third = null;
            while (n > 0)
            {
                third = curr.next;
                curr.next = prev;
                prev = curr;
                curr = third;
                n--;
            }

            // Adjust the final connections
            if (con != null)
            {
                con.next = prev;
            }
            else
            {
                head = prev;
            }

            tail.next = curr;
            return head;

        }
    }
}

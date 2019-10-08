using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class CheckPalindrome
    {
        public static bool IsPalindrome(Node head)
        {
            Node reversed = CloneAndReverse(head);
            return CompareLists(head, reversed);
        }

        private static Node CloneAndReverse(Node head)
        {
            Node resultHead = null;

            while (head != null)
            {
                Node n = new Node(head.val);
                n.next = resultHead;
                resultHead = n;
                head = head.next;
            }

            return resultHead;
        }

        private static bool CompareLists(Node head1, Node head2)
        {
            while (head1 != null && head2 != null)
            {
                if (head1.val != head2.val)
                {
                    return false;
                }

                head1 = head1.next;
                head2 = head2.next;
            }

            return head1 == null && head2 == null;
        }
    }
}

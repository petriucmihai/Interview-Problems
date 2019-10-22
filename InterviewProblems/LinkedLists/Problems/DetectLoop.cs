using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class DetectLoop
    {
        // Given a linked list, check if the linked list has loop or not
        public static bool DetectLoopWithHashing(Node head)
        {
            HashSet<Node> found = new HashSet<Node>();
            while (head != null)
            {
                if (found.Contains(head))
                    return true;

                found.Add(head);
                head = head.next;
            }

            return false;
        }

        public static bool DetectLoopWith2Pointers(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && slow != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        }
    }
}

using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class RemoveDuplicates
    {
        // Can use external data structure
        public static void DeleteDuplicatesWithBuffer(Node head)
        {
            if (head != null)
            {
                HashSet<Node> found = new HashSet<Node>();
                found.Add(head);
                Node curr = head.next;
                Node prev = head;

                while (curr != null)
                {
                    if (found.Contains(curr))
                    {
                        prev.next = curr.next;

                    }
                    else
                    {
                        found.Add(curr);
                        prev = curr;
                    }
                    curr = curr.next;
                }
            }
        }

        // No external data structure
        public static void DeleteDuplicatesWithoutBuffer(Node head)
        {
            if (head != null)
            {
                Node curr = head.next;

                while (curr != null)
                {
                    Node temp = curr;
                    while (temp != null)
                    {
                        if (temp == curr)
                        {
                            temp.next = temp.next.next;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }
                    curr = curr.next;
                }
            }
        }
    }
}

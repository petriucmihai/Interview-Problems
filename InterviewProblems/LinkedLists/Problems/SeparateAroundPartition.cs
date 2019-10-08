using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class SeparateAroundPartition
    {
        public static Node Separate(Node head, int part)
        {
            if (head != null && head.next != null)
            {
                Node node = head;
                Node tail = head;

                // Attach nodes less than part to head, otherwise append to tail
                while (node != null)
                {
                    Node next = node.next;
                    if (node.val < part)
                    {
                        node.next = head;
                        head = node;
                    }
                    else
                    {
                        tail.next = node;
                        tail = node;
                    }
                    node = next;
                }
                tail.next = null;

                return head;
            }

            return null;
        }
    }
}

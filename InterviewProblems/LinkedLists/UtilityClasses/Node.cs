using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.UtilityClasses
{
    class Node
    {
        public Node next;
        public int val;

        public Node()
        {
            next = null;
            val = 0;
        }

        public Node(int val)
        {
            next = null;
            this.val = val;
        }
    }
}

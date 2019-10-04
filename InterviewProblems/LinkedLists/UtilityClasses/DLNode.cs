using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.UtilityClasses
{
    class DLNode
    {
        public DLNode next;
        public DLNode prev;
        public int val;

        public DLNode()
        {
            next = null;
            prev = null;
            val = 0;
        }

        public DLNode(int val)
        {
            next = null;
            prev = null;
            this.val = val;
        }
    }
}

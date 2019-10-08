using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class AddAsNumbers
    {
        public static Node AddListsAsNumbers(Node num1, Node num2)
        {
            return AddLists(num1, num2, 0);
        }
        private static Node AddLists(Node num1, Node num2, int carry)
        {
            if (num1 == null && num2 == null && carry == 0)
            {
                return null;
            }

            Node newNode = new Node();

            int sum = carry;
            if (num1 != null)
                sum += num1.val;

            if (num2 != null)
                sum += num2.val;

            newNode.val = sum % 10;
            int newCarry = sum / 10;

            Node result = null;
            if (num1 != null || num2 != null)
            {
                if (num1 != null && num2 != null)
                {
                    result = AddLists(num1.next, num2.next, newCarry);
                }
                else if (num1 != null && num2 == null)
                {
                    result = AddLists(num1.next, null, newCarry);
                }
                else if (num1 == null && num2 != null)
                {
                    result = AddLists(null, num2.next, newCarry);
                }
            }
            newNode.next = result;

            //??
            return newNode;
        }
    }
}

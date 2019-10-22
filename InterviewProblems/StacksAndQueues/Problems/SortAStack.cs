using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.StacksAndQueues.Problems
{
    class SortAStack
    {
        // Given a stack of integers, sort it in ascending order

        public static void SortStackWithTempStack(Stack<int> input)
        {
            Stack<int> tempStack = new Stack<int>();
            while (input.Count > 0)
            {
                int num = input.Pop();
                while (tempStack.Count > 0 && tempStack.Peek() > num)
                {
                    input.Push(tempStack.Pop());
                }
                tempStack.Push(num);
            }
            input = tempStack;
        }


    }
}

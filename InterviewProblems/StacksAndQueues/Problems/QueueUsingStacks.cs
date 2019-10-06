using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.StacksAndQueues.Problems
{
    class QueueUsingStacks<T>
    {
        private Stack<T> stack1 = new Stack<T>();
        private Stack<T> stack2 = new Stack<T>();

        // O(n) time complexity
        public void Enqueue(T x)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(x);

            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public T Dequeue()
        {
            if (stack1.Count > 0)
            {
                return stack1.Pop();
            }

            throw new Exception("Queue is empty");
        }
    }
}

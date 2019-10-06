using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.StacksAndQueues.Problems
{
    class StackUsingQueue<T>
    {
        Queue<T> queue1 = new Queue<T>();
        Queue<T> queue2 = new Queue<T>();

        public void Push(T x)
        {
            queue2.Enqueue(x);
            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }

            Queue<T> q = queue1;
            queue1 = queue2;
            queue2 = q;
        }

        public T Pop()
        {
            if (queue1.Count > 0)
            {
                return queue1.Dequeue();
            }

            throw new Exception("Stack is empty");
        }
    }
}

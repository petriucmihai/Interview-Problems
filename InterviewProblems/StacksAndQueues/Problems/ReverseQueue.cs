using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.StacksAndQueues.Problems
{
    class ReverseQueue
    {
        public static void ReverseQueueWithStack(Queue<int> input)
        {
            Stack<int> tempStack = new Stack<int>();

            while (input.Count > 0)
            {
                tempStack.Push(input.Dequeue());
            }

            while (tempStack.Count > 0)
            {
                input.Enqueue(tempStack.Pop());
            }
        }

        /*
            Given an integer k and a queue of integers, we need to reverse the order of the 
            first k elements of the queue, leaving the other elements in the same relative order. 
        */
        public static void ReverseFirstKElementsOfQueue(Queue<int> input, int k)
        {
            if (input.Count < k || input.Count == 0)
            {
                throw new ArgumentException();
            }

            Stack<int> tempStack = new Stack<int>();
            
            for (int i = 0; i < k; i++)
            {
                tempStack.Push(input.Dequeue());
            }

            while (tempStack.Count > 0)
            {
                input.Enqueue(tempStack.Pop());
            }

            for (int i = 0; i < input.Count - k; i++)
            {
                input.Enqueue(input.Dequeue());
            }
        }
    }
}

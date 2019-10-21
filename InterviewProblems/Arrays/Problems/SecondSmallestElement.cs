using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class SecondSmallestElement
    {
        // Find the second smallest element in an array
        public static int FindSecondSmallest(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException();
            }
            
            int min = Int32.MaxValue;
            int second = Int32.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                // if item is min, update min and second
                if (array[i] < min)
                {
                    second = min;
                    min = array[i];
                }
                // if item is greater than min but less than second
                else if (array[i] < second && array[i] != min)
                {
                    second = array[i];
                }
            }

            return second;
        }
    }
}

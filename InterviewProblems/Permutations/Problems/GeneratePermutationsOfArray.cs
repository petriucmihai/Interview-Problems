using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Permutations.Problems
{
    class GeneratePermutationsOfArray
    {
        public static void PrintArrayPermutations(int[] array)
        {
            int[] arrayCopy = CopyIntArray(array);
            bool done = false;
            int i = 0; int j = i + 1;
            while (!done)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;

                // Print Array
                Console.Write("[ ");
                foreach (int num in array)
                {
                    Console.Write(num + ", ");
                }
                Console.WriteLine("]");


                if (j == array.Length - 1)
                {
                    i = 0;
                    j = i + 1;
                }
                else
                {
                    i++;
                    j++;
                }

                if (Enumerable.SequenceEqual(array, arrayCopy))
                    done = true;
            }
        }

        private static int[] CopyIntArray(int[] array)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            return result;
        }
    }
}

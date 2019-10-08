using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class URLifyString
    {
        public static string URLify(string input, int trueLength)
        {
            int spaceCount = 0;
            for (int i = 0; i < trueLength; i++)
            {
                if (input[i] == ' ')
                {
                    spaceCount++;
                }
            }

            char[] array = input.ToCharArray();

            int index = trueLength + spaceCount * 2;

            for (int i = trueLength - 1; i >= 0; i--)
            {
                if (array[i] == ' ')
                {
                    array[index - 1] = '0';
                    array[index - 2] = '2';
                    array[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    array[index - 1] = array[i];
                    index--;
                }
            }

            return new string(array);
        }
    }
}

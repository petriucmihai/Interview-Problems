using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class CellsArray
    {
        /*
        There are 8 prison cells in a row, and each cell is either occupied or vacant.

        Each day, whether the cell is occupied or vacant changes according to the following rules:

        If a cell has two adjacent neighbors that are both occupied or both vacant, then the cell becomes occupied.
        Otherwise, it becomes vacant.
        (Note that because the prison is a row, the first and the last cells in the row can't have two adjacent neighbors.)

        We describe the current state of the prison in the following way: cells[i] == 1 if the i-th cell is occupied, else cells[i] == 0.

        Given the initial state of the prison, return the state of the prison after N days (and N such changes described above.) 
        */
        public static int[] cellCompete(int[] states, int days)
        {
            // INSERT YOUR CODE HERE
            if (states == null || states.Length == 0 || days == 0)
            {
                return states;
            }

            bool hasCycle = false;
            int cycle = 0;
            HashSet<string> stateHistory = new HashSet<string>();

            for (int i = 0; i < days; i++)
            {
                int[] newStates = NextDay(states);
                string key = string.Join(",", newStates);
                if (stateHistory.Contains(key))
                {
                    hasCycle = true;
                    break;
                }
                else
                {
                    stateHistory.Add(key);
                    cycle++;
                }

                states = newStates;
            }

            if (hasCycle)
            {
                days = days % cycle;
                for (int i = 0; i < days; i++)
                {
                    states = NextDay(states);
                }
            }

            return states;
        }

        private static int[] NextDay(int[] states)
        {
            int[] newStates = new int[states.Length];
            for (int i = 0; i < states.Length; i++)
            {
                int left = 0;
                if (i > 0)
                {
                    left = states[i - 1];
                }

                int right = 0;
                if (i < states.Length - 1)
                {
                    right = states[i + 1];
                }

                if (left == right)
                {
                    newStates[i] = 0;
                }
                else
                {
                    newStates[i] = 1;
                }
            }

            return newStates;
        }
    }
}

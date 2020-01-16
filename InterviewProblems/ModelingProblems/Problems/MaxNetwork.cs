using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class MaxNetwork
    {
        // N cities, with M roads that connect them. Array A and B have M integers each, where A[i] and B[i] are the
        // 2 ends of the ith road. Max network rank is the most roads that are connected to either end of the city.
        public static int MaxRank(int[] A, int[] B, int N)
        {
            Dictionary<int, List<int>> connections = new Dictionary<int, List<int>>();

            for (int i = 0; i < A.Length; i++)
            {
                int cityA = A[i];
                int cityB = B[i];

                if (connections.ContainsKey(cityA))
                {
                    connections[cityA].Add(cityB);
                }
                else
                {
                    List<int> cityList = new List<int>();
                    cityList.Add(cityB);
                    connections.Add(cityA, cityList);
                }

                if (connections.ContainsKey(cityB))
                {
                    connections[cityB].Add(cityA);
                }
                else
                {
                    List<int> cityList = new List<int>();
                    cityList.Add(cityA);
                    connections.Add(cityB, cityList);
                }
            }

            int maxNetwork = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int network = connections[A[i]].Count + connections[B[i]].Count - 1;
                if (maxNetwork < network)
                {
                    maxNetwork = network;
                }
            }

            return maxNetwork;
        }
    }
}

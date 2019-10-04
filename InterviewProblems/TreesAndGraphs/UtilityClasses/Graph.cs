using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.TreesAndGraphs.UtilityClasses
{
    class Graph<T>
    {
        // Adjacency List
        Dictionary<T, List<T>> adjList = new Dictionary<T, List<T>>();

        public void AddEdge(T start, T end)
        {
            if (adjList.ContainsKey(start) && adjList.ContainsKey(end))
            {
                adjList[start].Add(end);
            }
        }

        public void AddNode(T node)
        {
            if (!adjList.ContainsKey(node))
            {
                adjList.Add(node, new List<T>());
            }
        }

        public List<T> AdjacentNodes(T node)
        {
            if (adjList.ContainsKey(node))
            {
                return adjList[node];
            }

            return null;
        }
    }
}

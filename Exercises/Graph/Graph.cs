using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exercises
{
    public class GraphExercise
    {
        private int numberOfNodes;
        private Dictionary<int, List<int>> adjacentList;

        public GraphExercise()
        {
            this.numberOfNodes = 0;
            this.adjacentList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(GraphNode node)
        {
            if(this.adjacentList.ContainsKey(node.Value))
                    return;

            this.adjacentList.Add(node.Value, new List<int>());
            this.numberOfNodes++;
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {
            if (!this.adjacentList.ContainsKey(node1.Value) || !this.adjacentList.ContainsKey(node2.Value))
                return;

            // This is an undirected graph so we have to do it both ways!
            var edgelist1 = this.adjacentList[node1.Value];
            edgelist1.Add(node2.Value);

            var edgelist2 = this.adjacentList[node2.Value];
            edgelist2.Add(node1.Value);
        }

        public int GetNumberOfNodes()
        {
            return this.numberOfNodes;
        }

        public void ShowConnections()
        {
            foreach (var item in adjacentList)
            {
                List<int> nodeConnections = adjacentList[item.Key];
                StringBuilder connections = new StringBuilder();

                foreach (int edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");
                }

                Trace.Write(item.Key + "-->" + connections);
            }
        }
    }

    public class GraphNode
    {
        public int Value { get; set; }

        public GraphNode(int value)
        {
            this.Value = value;
        }
    }
}

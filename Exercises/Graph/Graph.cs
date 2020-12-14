using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exercises
{
    public class GraphExercise  // Adjacenty list.
    {
        private int numberOfNodes = 0;
        private Dictionary<int, List<int>> adjacentList = new Dictionary<int, List<int>>();

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
            List<int> node1_edgelist = this.adjacentList[node1.Value];
            node1_edgelist.Add(node2.Value);

            List<int> node2_edgelist = this.adjacentList[node2.Value];
            node2_edgelist.Add(node1.Value);
        }

        public void RemoveEdge(GraphNode node1, GraphNode node2)
        {
            if (!this.adjacentList.ContainsKey(node1.Value) || !this.adjacentList.ContainsKey(node2.Value))
                return;

            // This is an undirected graph so we have to do it both ways!
            List<int> node1_edgelist = this.adjacentList[node1.Value];
            node1_edgelist.Remove(node2.Value);

            List<int> node2_edgelist = this.adjacentList[node2.Value];
            node2_edgelist.Remove(node1.Value);
        }

        //public void RemoveVertex(GraphNode node) // Not working!!!
        //{
        //    if (!this.adjacentList.ContainsKey(node.Value))
        //        return;

        //    for (var i = 0; i < this.adjacentList[node.Value].Count; i++)
        //    {
        //        var vertex = this.adjacentList[node.Value];
        //        var l2 = this.adjacentList;
        //        //this.RemoveEdge(node, l2);
        //    }

        //    this.adjacentList.Remove(node.Value);
        //    this.numberOfNodes--;
        //}

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

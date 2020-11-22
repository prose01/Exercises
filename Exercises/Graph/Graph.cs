using System.Collections.Generic;

namespace Exercises
{
    public class Graph
    {
        private int numberOfNodes;
        private Dictionary<int, List<int>> adjacentList;

        public Graph()
        {
            this.numberOfNodes = 0;
            this.adjacentList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(GraphNode node)
        {
            this.numberOfNodes++;
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {

        }

        public void ShowConnections()
        {

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

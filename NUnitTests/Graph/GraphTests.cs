using Exercises;
using NUnit.Framework;

namespace NUnitTests.Graph
{
    public class GraphTests
    {
        [Test]
        public void TestingGraphAddVertex()
        {
            var graph = new GraphExercise();

            graph.AddVertex(new GraphNode(0));
            graph.AddVertex(new GraphNode(1));
            graph.AddVertex(new GraphNode(2));
            graph.AddVertex(new GraphNode(3));
            graph.AddVertex(new GraphNode(4));
            graph.AddVertex(new GraphNode(5));
            graph.AddVertex(new GraphNode(6));

            graph.ShowConnections();

            var result = graph.GetNumberOfNodes();

            Assert.AreEqual(7, result);
        }

        // Run in Debug mode and look in Output -> Debug to see result.
        [Test]
        public void TestingGraphAddEdges()
        {
            var graph = new GraphExercise();

            graph.AddVertex(new GraphNode(0));
            graph.AddVertex(new GraphNode(1));
            graph.AddVertex(new GraphNode(2));
            graph.AddVertex(new GraphNode(3));
            graph.AddVertex(new GraphNode(4));
            graph.AddVertex(new GraphNode(5));
            graph.AddVertex(new GraphNode(6));

            graph.AddEdge(new GraphNode(3), new GraphNode(1));
            graph.AddEdge(new GraphNode(3), new GraphNode(4));
            graph.AddEdge(new GraphNode(4), new GraphNode(2));
            graph.AddEdge(new GraphNode(4), new GraphNode(5));
            graph.AddEdge(new GraphNode(1), new GraphNode(2));
            graph.AddEdge(new GraphNode(1), new GraphNode(0));
            graph.AddEdge(new GraphNode(0), new GraphNode(2));
            graph.AddEdge(new GraphNode(6), new GraphNode(5));

            graph.ShowConnections();
        }

        [Test]
        public void TestingGraphAddEdgesSimpler()
        {
            var graph = new GraphExercise();

            graph.AddVertex(new GraphNode(0));
            graph.AddVertex(new GraphNode(1));
            graph.AddVertex(new GraphNode(2));

            graph.AddEdge(new GraphNode(0), new GraphNode(1));
            graph.AddEdge(new GraphNode(1), new GraphNode(2));
            graph.AddEdge(new GraphNode(2), new GraphNode(0));

            graph.ShowConnections();
        }

        [Test]
        public void TestingGraphRemoveEdge()
        {
            var graph = new GraphExercise();

            graph.AddVertex(new GraphNode(0));
            graph.AddVertex(new GraphNode(1));
            graph.AddVertex(new GraphNode(2));

            graph.AddEdge(new GraphNode(0), new GraphNode(1));
            graph.AddEdge(new GraphNode(1), new GraphNode(2));
            graph.AddEdge(new GraphNode(2), new GraphNode(0));

            graph.RemoveEdge(new GraphNode(1), new GraphNode(2));

            graph.ShowConnections();
        }

        //[Test]
        //public void TestingGraphRemoveVertex()
        //{
        //    var graph = new GraphExercise();

        //    graph.AddVertex(new GraphNode(0));
        //    graph.AddVertex(new GraphNode(1));
        //    graph.AddVertex(new GraphNode(2));

        //    graph.AddEdge(new GraphNode(0), new GraphNode(1));
        //    graph.AddEdge(new GraphNode(1), new GraphNode(2));
        //    graph.AddEdge(new GraphNode(2), new GraphNode(0));

        //    graph.RemoveVertex(new GraphNode(1));

        //    graph.ShowConnections();
        //}
    }
}

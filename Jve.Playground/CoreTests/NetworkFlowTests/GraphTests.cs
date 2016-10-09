using Core.NetworkFlow.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace CoreTests.NetworkFlowTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void GraphInitializeTest()
        {
            // Define nodes
            var nodeS = new Vertex("S");
            var nodeT = new Vertex("T");
            

            // Define edges
            var graphNodes = new List<Vertex> {
                nodeS
                    .With(Edge.To(nodeT, 20)),
                nodeT
            };
            var g1 = new Graph { Vertices = graphNodes };

            g1.GetAdjacencyList().ToList().ForEach(Console.WriteLine);
        }

        [TestMethod]
        public void FindPathTest()
        {
            // Define nodes
            var nodeT = new Vertex("T");
            var nodeU = new Vertex("U");
            var nodeV = new Vertex("V");
            var nodeS = new Vertex("S");

            // Define edges
            var graphNodes = new List<Vertex> {
                nodeS
                    .With(Edge.To(nodeV, 20))
                    .With(Edge.To(nodeU, 10)),
                nodeV
                    .With(Edge.To(nodeT, 10))
                    .With(Edge.To(nodeU, 30)),
                nodeU
                    .With(Edge.To(nodeT, 20)),                    
                nodeT
            };
            var g1 = new Graph { Vertices = graphNodes };

            g1.GetAdjacencyList().ToList().ForEach(Console.WriteLine);

            var path = g1.FindPath(nodeS, "T");

            path.Count.ShouldBe(2);
            var targetIds = path.Select(x => x.Target.Id);
            targetIds.ShouldContain("V");
            targetIds.ShouldContain("T");
        }

        [TestMethod]
        public void FindPathInCyclicTest()
        {
            // Define nodes
            var nodeT = new Vertex("T");
            var nodeY = new Vertex("Y");
            var nodeU = new Vertex("U");
            var nodeV = new Vertex("V");
            var nodeS = new Vertex("S");

            // Define edges
            var graphNodes = new List<Vertex> {
                nodeS
                    .With(Edge.To(nodeV, 20))
                    .With(Edge.To(nodeU, 10)),
                nodeV
                    .With(Edge.To(nodeU, 30)),
                nodeU
                    .With(Edge.To(nodeY, 20)),
                nodeY
                    .With(Edge.To(nodeV, 20))
                    .With(Edge.To(nodeT, 20)),
                nodeT
            };
            var g1 = new Graph { Vertices = graphNodes };

            g1.GetAdjacencyList().ToList().ForEach(Console.WriteLine);
        }
    }
}

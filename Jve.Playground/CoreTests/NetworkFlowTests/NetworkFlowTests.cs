using Core.NetworkFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests.NetworkFlowTests
{
    [TestClass]
    public class NetworkFlowTests
    {
        [TestMethod]
        public void M1()
        {
            var networkflow = new NetworkFlow();
            var result = networkflow.Add2(2, 3);

            networkflow.LastAddition.ShouldBe(5);
            result.ShouldBe(6);
        }

        [TestMethod]
        public void GraphInitializeTest()
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

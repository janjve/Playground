using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.NetworkFlow;
using Core.NetworkFlow.DataStructures;

namespace CoreTests.NetworkFlowTests
{
    [TestClass]
    public class NetworkFlowTests
    {
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

        [TestMethod]
        public void NetworkFlowTest()
        {
            // Define nodes
            var nodeS = new Vertex(NetworkFlow.SourceId);
            var nodeV = new Vertex("V");
            var nodeU = new Vertex("U");
            var nodeT = new Vertex(NetworkFlow.TargetId);

            // Define edges
            var g = new Graph
            {
                Vertices = new List<Vertex> {
                    nodeS
                        .With(Edge.To(nodeV, 20))
                        .With(Edge.To(nodeU, 10)),
                    nodeV
                        .With(Edge.To(nodeU, 30))
                        .With(Edge.To(nodeT, 10)),
                    nodeU
                        .With(Edge.To(nodeT, 20)),
                    nodeT
                }
            };

            // Pre sanity check
            g.GetAdjacencyList().ToList().ForEach(x => Console.WriteLine($"[IN] {x}"));

            var output = NetworkFlow.Run(g);

            output.ShouldNotBeNull();
            output.Flow.ShouldNotBeNull();

            // Post sanity check
            output.Flow.ToList().ForEach(kv => Console.WriteLine($"[OUT] {kv.Key} ({kv.Value})"));

            output.FlowValue.ShouldBe(30);
            output.Flow["S -> V"].ShouldNotBeNull();
            output.Flow["S -> U"].ShouldNotBeNull();
            output.Flow["V -> U"].ShouldNotBeNull();
            output.Flow["V -> T"].ShouldNotBeNull();
            output.Flow["U -> T"].ShouldNotBeNull();

            output.Flow["S -> V"].ShouldBe(20);
            output.Flow["S -> U"].ShouldBe(10);
            output.Flow["V -> U"].ShouldBe(10);
            output.Flow["V -> T"].ShouldBe(20);
            output.Flow["U -> T"].ShouldBe(20);
        }
    }
}

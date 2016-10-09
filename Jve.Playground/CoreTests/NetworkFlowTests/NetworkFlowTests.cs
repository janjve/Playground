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
        public void NetworkFlowTest()
        {
            // Define nodes
            var S = "S";
            var V = "V";
            var U = "U";
            var T = "T";

            // Define edges
            var g = new Graph()
                .WithEdge(from: S, to: V, capacity: 10)
                .WithEdge(from: S, to: U, capacity: 20)
                .WithEdge(from: V, to: U, capacity: 30)
                .WithEdge(from: V, to: T, capacity: 10)
                .WithEdge(from: U, to: T, capacity: 20)
                ;

            // Pre sanity check
            g.Edges.ForEach(x => Console.WriteLine($"[IN] {x}"));

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
            output.Flow["V -> T"].ShouldBe(10);
            output.Flow["U -> T"].ShouldBe(20);
        }
    }
}

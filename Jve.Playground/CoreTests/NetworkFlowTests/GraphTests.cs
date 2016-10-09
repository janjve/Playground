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
        public void Test2()
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
            g.Edges.ForEach(Console.WriteLine);

            var path = g.FindPath("S", "T");
            Console.WriteLine($"result: {path.Count}");
            path.ForEach(Console.WriteLine);
        }

        [TestMethod]
        public void FindPathTest()
        {
            // TODO
        }

        [TestMethod]
        public void FindPathInCyclicTest()
        {
            // TODO
        }
    }
}

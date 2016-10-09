using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.NetworkFlow.DataStructures;

namespace Core.NetworkFlow
{
    public static class NetworkFlow
    {
        public const string TargetId = "T";
        public const string SourceId = "S";

        public static NetworkFlowSummary Run(Graph g)
        {
            if (!ValidateGraph(g)) throw new InvalidOperationException("Invalid graph");

            // Initial flow with throughput 0 on all edges.
            var f = g.GetEdges().ToDictionary(x => x, x => 0);
            var v = FlowValue(f);

            // TODO: Network flow algorithm.

            // Dummy
            return new NetworkFlowSummary { Flow = new Dictionary<string, int> { { "dummyS -> dummyT", 10 } }, FlowValue = 10 };
        }

        private static int FlowValue(Dictionary<Edge, int> flow)
        {
            return flow.Where((k, v) => k.Key.Target.Id.Equals(TargetId)).Sum(kv => kv.Value);
        }

        public static List<Edge> FindPath(Vertex from, string targetId)
        {
            var targetEdge = from.AdjacencyList.SingleOrDefault(x => x.Target.Id.Equals(targetId));
            if (targetEdge != null) return new List<Edge> { targetEdge };

            foreach (var e in from.AdjacencyList.Where(x => x.IsFullCapacity()))
            {
                FindPath(e.Target)
            }

            return null;
        }

        // Should be moved and improved.
        private static bool ValidateGraph(Graph g)
        {
            var foundTap = false;
            var foundSource = false;

            foreach (var v in g.Vertices)
            {

                if (!foundSource) foundSource = v.Id.Equals(SourceId);
                else if (v.Id.Equals(SourceId)) throw new InvalidOperationException("Found double source");

                if (!foundTap) foundTap = v.Id.Equals(SourceId);
                else if (v.Id.Equals(foundTap)) throw new InvalidOperationException("Found double tap");
            }
            if (!foundTap || !foundSource) throw new InvalidOperationException("Missing source or tap");
            return true;
        }
    }
}
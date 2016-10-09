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
            // Initial flow with throughput 0 on all edges.
            var f = g.GetEdges().ToDictionary(x => x, x => 0);
            var v = FlowValue(f);

            // TODO: Network flow algorithm.

            // Dummy
            return new NetworkFlowSummary { Flow = new Dictionary<string, int> { { "dummyS -> dummyT", 10 } }, FlowValue = 10 };
        }

        private static int FlowValue(Dictionary<Edge, int> flow)
        {
            return flow.Where((k, v) => k.Key.Target.Equals(TargetId)).Sum(kv => kv.Value);
        }
    }
}
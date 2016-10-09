using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow.DataStructures
{
    public interface IGraph
    {
        Graph GenerateResidualGraph();
        List<Edge> FindPath(string from, string to);
        void AugmentGraph(int flow, int capacity, List<Edge> path);
    }
}

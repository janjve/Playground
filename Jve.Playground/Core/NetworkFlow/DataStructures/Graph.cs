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

    public class Graph
    {
        public List<Vertex> Vertices { get; set; }

        public Graph GenerateResidualGraph()
        {
            throw new NotImplementedException();
        }

        public List<Edge> GetEdges()
        {
            return Vertices.SelectMany(x => x.AdjacencyList).ToList();
        }

        public IEnumerable<string> GetAdjacencyList()
        {
            return Vertices.Select(x => x.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow
{
    public class Graph
    {
        public List<Vertex> Vertices{ get; set; }

        public Graph GenerateResidualGraph()
        {
            // TODO
            return new Graph();
        }
        public IEnumerable<string> GetAdjacencyList()
        {
            return Vertices.Select(x => x.ToString());
        }
    }

    public class Edge
    {
        public Vertex Target { get; set; }
        public int Capacity { get; set; }

        public Edge(Vertex target, int capacity)
        {
            this.Target = target;
            this.Capacity = capacity;
        }

        public static Edge To(Vertex target, int capacity)
        {
            return new Edge(target, capacity);
        }

        public override string ToString()
        {
            return $"[{Target.Id}:{Capacity}]";
        }
    }

    public class Vertex
    {
        public string Id { get; set; }
        public List<Edge> AdjacencyList { get; set; }
        public Vertex(string id)
        {
            Id = id;
            AdjacencyList = new List<Edge>();
        }

        public Vertex With(Edge e)
        {
            AdjacencyList.Add(e);
            return this;
        }

        public override string ToString()
        {
            return $"{Id} -> {string.Join(", ", AdjacencyList)}";
        }
    }
}

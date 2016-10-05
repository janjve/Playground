using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow.DataStructures
{
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
            return $"{Id} -> ({string.Join(", ", AdjacencyList)})";
        }
    }
}

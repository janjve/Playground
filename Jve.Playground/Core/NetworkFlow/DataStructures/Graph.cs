using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow.DataStructures
{
    public class Graph
    {
        //public static HashSet<string> Vertices { get; set; }
        public List<Edge> Edges { get; set; }
        public List<Tuple<Edge, Edge>> ResidualEdges { get; set; }

        public Graph()
        {
            Edges = new List<Edge>();
            ResidualEdges = new List<Tuple<Edge, Edge>>();
        }

        public Graph GenerateResidualGraph()
        {
            throw new NotImplementedException();
        }

        public List<Edge> GetEdges()
        {
            return Edges.ToList();
        }

        public Graph WithEdge(string from, string to, int capacity)
        {
            Edges.Add(new Edge(from, to, capacity));
            ResidualEdges.Add(new Tuple<Edge, Edge>(new Edge(from, to, capacity), new Edge(to, from, capacity)));
            return this;
        }

        public void Augment(List<Edge> path)
        {
            var bottleneck = path.Min(x => x.Capacity - x.Flow);
            foreach(var edge in Edges)
            {
                // TODO
            }
        }

        public List<Edge> FindPath(string from, string to)
        {
            return DepthFirstPath(from, to, Edges).ToList();
        }

        private LinkedList<Edge> DepthFirstPath(string from, string to, List<Edge> edges)
        {
            var predicateSplit = Edges.ToLookup(x => x.Source.Equals(from));
            if (!predicateSplit[true].Any()) { return new LinkedList<Edge>(); }

            var target = predicateSplit[true].FirstOrDefault(x => x.Target.Equals(to) && x.Capacity > x.Flow);

            if (target != null)
            {
                var result = new LinkedList<Edge>();
                result.AddFirst(target);
                return result;
            }
            else
            {
                var nextList = predicateSplit[true].Where(x => x.Capacity > x.Flow).OrderBy(x => x.Capacity);
                foreach (var next in nextList)
                {
                    var result = DepthFirstPath(next.Target, to, predicateSplit[false].ToList());
                    if (result.Any())
                    {
                        result.AddFirst(next);
                        return result;
                    }
                }
                return new LinkedList<Edge>();
            }
        }
    }
}

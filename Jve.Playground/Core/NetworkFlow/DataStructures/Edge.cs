using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow.DataStructures
{
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
}

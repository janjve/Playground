using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow.DataStructures
{
    public class Edge
    {
        public string Target { get; set; }
        public string Source { get; set; }
        public int Capacity { get; set; }
        public int Flow { get; set; }

        public Edge(string source, string target, int capacity)
        {
            this.Source = source;
            this.Target = target;
            this.Capacity = capacity;
            this.Flow = 0;
        }

        public bool IsFullCapacity()
        {
            return Capacity <= Flow;
        }

        public override string ToString()
        {
            return $"[({Source} -> {Target}):{Capacity}]";
        }
    }
}

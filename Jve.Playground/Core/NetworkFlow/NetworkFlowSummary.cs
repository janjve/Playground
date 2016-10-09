using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow
{
    public class NetworkFlowSummary
    {
        public Dictionary<string, int> Flow { get; set; }
        public int FlowValue { get; set; }
    }
}

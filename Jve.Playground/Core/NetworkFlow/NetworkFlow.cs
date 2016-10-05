using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.NetworkFlow
{
    public class NetworkFlow
    {
        public int LastAddition { get; set; }
        public int Add2(int a, int b)
        {
            LastAddition = a + b;
            return LastAddition;
        }
    }
}

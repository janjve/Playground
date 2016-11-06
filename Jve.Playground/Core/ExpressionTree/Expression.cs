using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExpressionTree
{
    public class Expression : Element
    {
        public Element Left { get; set; }
        public Element Right { get; set; }
        public Operator Operator { get; set; }
    }
}

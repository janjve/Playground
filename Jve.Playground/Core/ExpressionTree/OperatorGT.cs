using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExpressionTree
{
    public class OperatorGT : Operator
    {
        public bool Run(int left, int right) => left > right;
    }
}

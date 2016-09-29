using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Alignment
{
    public static class StepAlignmentConfiguration
    {
        public static int Alpha (char x, char y) => x == y ? 1 : 0;
        public static int Delta { get; } = -1;
        public static int Max(int x, int y, int z) => Math.Max(Math.Max(x, y), z);
    }
}

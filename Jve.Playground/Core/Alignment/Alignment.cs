using System;
using System.Collections.Generic;

namespace Core.Alignment
{
    public class Alignment
    {
        private readonly Func<char, char, int> _alpha;
        private readonly int _delta;
        private readonly Func<int, int, int, int> _comparer;

        public Alignment(Func<char, char, int> alpha, int delta, Func<int, int, int, int> comparer)
        {
            _alpha = alpha;
            _delta = delta;
            _comparer = comparer;
        }

        public int Evaluate(string x, string y)
        {
            if(x == null || y == null) throw new NullReferenceException();
            if (string.IsNullOrEmpty(x)) return y.Length * _delta;
            if (string.IsNullOrEmpty(y)) return x.Length * _delta;

            var memory = new int[x.Length + 1, y.Length + 1];

            for (var i = 1; i <= x.Length; i++)
                memory[i, 0] = _delta;

            for (var j = 1; j <= y.Length; j++)
                memory[0, j] = _delta;

            return RouteIterative(memory, x, y);
        }

        private int RouteIterative(int[,] memory, string x, string y)
        {
            for (var i = 1; i <= x.Length; i++)
            {
                for (var j = 1; j <= y.Length; j++)
                {
                    memory[i, j] = _comparer(
                        memory[i - 1, j] + _delta,
                        memory[i - 1, j - 1] + _alpha(x[i - 1], y[j - 1]),
                        memory[i, j - 1] + _delta
                        );
                }
            }

            return memory[x.Length, y.Length];
        }
    }
}

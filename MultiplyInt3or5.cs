
using System;
using System.Linq;

namespace Codewars
{
    class MultiplyInt3or5 : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func(0);
        }

        private static int Func(int n)
        {
            var range = Enumerable.Range(0, n);
            var res = range.Count() > 0 ? range.Aggregate( (agg, el) => agg += (el % 3 == 0 || el % 5 == 0) ? el : 0) : 0;
            return 0;
        }
    }
}
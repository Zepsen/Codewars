using System;
using System.Linq;
namespace Codewars
{
    class StrRepeat : ICodeWars
    {
        
        object ICodeWars.Start()
        {
            return Func(5, "Hello");
        }

        string Func(int n, string s)
        {
            var res = string.Concat(Enumerable.Repeat(s, n));
            return res;
        }
    }
}

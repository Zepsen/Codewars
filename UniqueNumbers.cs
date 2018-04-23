using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class UniqueNumbers : ICodeWars
    {
        object ICodeWars.Start()
        { 
            return Func(new[] {1,1,12,1,1});            
        }

        object Func(IEnumerable<int> numbers)
        {
           var res = numbers.GroupBy(i => i).Select(s => s.Count()).ToList();
           return res;
        }
    }
}
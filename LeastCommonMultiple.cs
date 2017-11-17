using System;
using System.Collections.Generic;

namespace Codewars
{
    public class LeastCommonMultiple : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func(new List<int>{2,3,4});
        }

        private object Func(List<int> list)
        {
            return 0;
        }
    }
}
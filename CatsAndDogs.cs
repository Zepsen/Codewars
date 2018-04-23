using System.Collections.Generic;
using System.Diagnostics;

namespace Codewars
{
    public class CatsAndDogs : ICodeWars
    {
        public object Start()
        {
            return Func(new List<char> { 'D','D', 'C', 'D', 'C', 'C' }, 2);
        }

        public int Func(List<char> xs, int n)
        {
            
            int res = 0;
            int cats = 0;
            int dogs = 0;
            for (var i = 0; i < xs.Count; i++)
            {
                if (xs[i] == 'D') {
                    dogs++;
                    continue;
                }
                
                cats++;
                var caught = false;
                for (int y = i - n; y <= i + n; y++)
                {
                    if (y > -1 && y != i && y < xs.Count && xs[y] == 'D')
                    {
                        caught = true;
                    }
                }

                if (!caught) res++;
            }
            return dogs < cats - res ? dogs : cats - res;
        }
    }
}

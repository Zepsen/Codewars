using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Codewars
{
    public class CatsAndDogs : ICodeWars

    {        
        public object Start()
        {
            return Func(new List<char>{'D','C','C','D','C'}, 2);   
        }

        public int Func(List<char> xs, int n)
        {
            var caught = new HashSet<int>();
            for (int i = 0; i < xs.Count; i++)
            {
                if (xs[i] == 'C') continue;
                for (int j = i - n; j <= i + n; j++)
                {
                    if (j < 0 || j >= xs.Count) continue;
                    if (xs[j] == 'C' && !caught.Contains(j)) { 
                        caught.Add(j); 
                        break; 
                    }
                }
            }
            return caught.Count;
        }
    }
}

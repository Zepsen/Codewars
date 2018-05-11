using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Diagnostics;
using System.Linq;
>>>>>>> c719013c62b85e4ed26f6642e25bc1d5f5bd3191

namespace Codewars
{
    public class CatsAndDogs : ICodeWars
<<<<<<< HEAD
    {        
        public object Start()
        {
            return Func(new List<char>{'D','C','C','D','C'}, 2);
=======
    {
        public object Start()
        {
            return Func(new List<char> { 'C', 'C', 'C', 'D', 'D', 'C', 'D', 'C', 'C' }, 2);
>>>>>>> c719013c62b85e4ed26f6642e25bc1d5f5bd3191
        }

        public int Func(List<char> xs, int n)
        {
<<<<<<< HEAD
            
            return 0;
        }
    }
}
=======
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
>>>>>>> c719013c62b85e4ed26f6642e25bc1d5f5bd3191

using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class IndexedCapitalization : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func("asddfgh", new List<int> {1, 2, 5});
        }

        private string Func(string s, List<int> idxs)
        {
            return new string(s.Select((l,i) => (idxs.Contains(i) ? char.ToUpper(l) : l)).ToArray());
        }
    }
}
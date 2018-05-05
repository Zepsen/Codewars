using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    /// <summary>
    /// 
    /// </summary>
    public class AddedChar : ICodeWars
    {        
        public object Start()
        {          
            return Merge(
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}}
                );
        }

        public Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            var res = new Dictionary<TKey, TValue[]>();
            foreach (var item in dicts)
            {
                if(item.Count == 0) continue;

                foreach (var key in item.Keys)
                {
                    if(res.ContainsKey(key))
                    {
                        res[key] = res[key].Concat(new TValue[] {item[key]}).ToArray();
                    }
                    else 
                    {
                        res.Add(key, new TValue[] { item[key]});
                    }
                }                
            }
            
            return res;
        }
    }
}
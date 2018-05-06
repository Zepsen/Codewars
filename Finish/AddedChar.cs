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
            return Best(
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"A", 1}}, 
                new Dictionary<string, int>{{"B", 2}},
                new Dictionary<string, int>{{"B", 3}},
                new Dictionary<string, int>{{"B", 4}}
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

         public Dictionary<TKey, TValue[]> Merge2<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            var res = new Dictionary<TKey, List<TValue>>();
            foreach (var item in dicts)
            {
                if(item.Count == 0) continue;                
                foreach (var key in item.Keys)
                {
                    if(res.ContainsKey(key))
                    {
                        res[key].Add(item[key]);
                    }
                    else 
                    {
                        res.Add(key, new List<TValue> { item[key]});
                    }
                }                
            }            
            return res.ToDictionary(i => i.Key, i => i.Value.ToArray());       
        }
       
        public Dictionary<TKey, TValue[]> Best<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            var s1 = dicts.SelectMany(i => i);
            var s2 = s1.GroupBy(k => k.Key);
            var s3 = s2.ToDictionary(g => g.Key, g => g.Select(i => i.Value).ToArray());      

           return dicts
            .SelectMany(m => m)
            .GroupBy(p => p.Key)
            .ToDictionary(g => g.Key, g => g.Select(i => i.Value).ToArray());      
        }
    }
}
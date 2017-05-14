

using System;
using System.Collections.Generic;
using System.Linq;


namespace Codewars
{
    class NextBiggerNumber : ICodeWars
    {
        public object Start()
        {
            return Func2(1630546898);
        }

        public long Func(long num)
        {
            var list = num.ToString().Select(n => n-'0').ToList();
            var indx = GetIndexOfLastBiggestThanPrevious(list);           
            if(indx < 0) return -1;
            var res = list.Take(indx).ToList();
            var skipped = list.Skip(indx+1).ToList();           
            var min = skipped.Where(i => i > list[indx]).Min();
            skipped.Remove(min);
            skipped.Add(list[indx]);
            skipped.Sort();
            res.Add(min);            
            res.AddRange(skipped);
            return Convert.ToInt64(String.Join("", res.ToArray()));            
        }

        private int GetIndexOfLastBiggestThanPrevious(List<int> list)
        {
            for(int i = list.Count - 1 ; i > -1; i--)
            {                
                    if(i != 0 && list[i] > list[i-1])
                    {
                        return i-1;                                                               
                    }                
            }

            return -1;
        }

        //Best
        private long Func2(long n)
        {
            if (n<10) return -1;
            string s=n+"";
            for (int i=s.Length-2;i>=0;i--){
                var s1 = s.Substring(i);
                var s2 = string.Concat(s.Substring(i).OrderByDescending(x=>x));
                if (s1!=s2)
                {
                    var t=string.Concat(s.Substring(i).OrderBy(x=>x));
                    var c=t.First(x=>x>s[i]);
                    return long.Parse(s.Substring(0,i)+c+string.Concat(t.Where((x,y)=>y!=t.IndexOf(c))));
                }
            }
            return -1;
        }
        
    }

}

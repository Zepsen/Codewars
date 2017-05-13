

using System;
using System.Collections.Generic;
using System.Linq;


namespace Codewars
{
    class NextBiggerNumber : ICodeWars, IIntInt
    {
        public object Start()
        {
            return Func(2027333);
        }

        public int Func(int num)
        {
            var list = num.ToString().Select(n => n - '0').ToList();
            var indx = 0;
            var res = new List<int>();

            for(int i = list.Count - 1 ; i > 0; i--)
            {
                if(indx == 0)
                {
                    if(i != 0 && list[i] > list[i-1])
                    {
                        indx = i-1;                                       
                    }
                }                
                else 
                {
                    res = list.Take(indx).ToList();
                }
            }

            if(indx == 0) return -1;

            var skipped = list.Skip(indx+1).ToList();
            var min = skipped.Min(s => s > list[indx]) ? skipped.Min() : list[indx+1];
            skipped.RemoveAt(skipped.First(i => i == min));
            skipped.Add(list[indx]);
            res.Add(min);
            skipped.Sort();
            res.AddRange(skipped);
            return Convert.ToInt32(String.Join("", res.ToArray()));            
        }
        
    }

}

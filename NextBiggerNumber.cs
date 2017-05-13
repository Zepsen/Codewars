

using System;
using System.Collections.Generic;
using System.Linq;


namespace Codewars
{
    class NextBiggerNumber : ICodeWars, IIntInt
    {
        public object Start()
        {
            return Func(13111);
        }

        public int Func(int num)
        {
            var list = num.ToString().Select(n => n - '0').ToList();
            var indx = 0;
           
            for(int i = list.Count - 1 ; i > -1; i--)
            {                
                    if(i != 0 && list[i] > list[i-1])
                    {
                        indx = i-1;  
                        break;                                     
                    }                
            }

            if(indx < 0) return -1;

            var res = list.Take(indx).ToList();
            var skipped = list.Skip(indx+1).ToList();
            var min = skipped.Min(s => s > list[indx]) ? skipped.Min() : list[indx+1];
            skipped.Remove(min);
            skipped.Add(list[indx]);
            skipped.Sort();
            res.Add(min);            
            res.AddRange(skipped);
            return Convert.ToInt32(String.Join("", res.ToArray()));            
        }
        
    }

}

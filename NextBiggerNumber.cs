

using System;
using System.Collections.Generic;
using System.Linq;


namespace Codewars
{
    class NextBiggerNumber : ICodeWars, IIntInt
    {
        public object Start()
        {
            return Func(2017);
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

            return 0;
        }
        
    }

}

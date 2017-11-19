using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class LeastCommonMultiple : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func(new List<int>{1,1});
            //return Lcm(new List<int>{5});
        }

    // public static int Lcm(List<int> nums) => nums.DefaultIfEmpty(1).Aggregate(Lcm);

    // private static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);
    // private static int Lcm(int a, int b) => a * b / Gcd(a, b);

        // public static int Gcd2(int a, int b) => b == 0 ? a : Gcd2(b, a % b);
        // public static int Lcm2(int a, int b) => a * b / Gcd2(a, b);
        // public static int Lcm(List<int> nums) => nums.Aggregate(1, Lcm2);

        
        [Obsolete("OUT OF MEMORY EXCEPTIONS")]
        private object Func(List<int> nums)
        {
            //0 Validation
            if(nums.Count == 0) return 1;
            if(nums.Contains(0)) return 1;
            if(nums.Count == 1) return nums.First();

            //1  Group by simple multipliers for each num          
            var groups = new List<List<IGrouping<int,int>>>();
            nums.ForEach(n => 
            {                
                var list = new List<int>{1};
                var i = 2;
                var temp = n;
                while(temp > 1)
                {
                    if(temp%i != 0) i++;
                    else { list.Add(i); temp/=i; i = 2; }                                         
                }
                groups.Add(list.GroupBy(j => j).ToList()); 
            });

            //2 Get max simple multipliers for each num
            var dic = new Dictionary<int, int>();   
            groups.ForEach(i => i.ForEach(j => {
                if(!dic.ContainsKey(j.Key)) dic.Add(j.Key, j.Count());
                else if(dic[j.Key] < j.Count()) dic[j.Key] = j.Count();
            }));

            //3 Aggregate result          
            return dic.Select(i => (int)Math.Pow(i.Key, i.Value)).Aggregate((i,e) => i * e);
 
        }
    }
}
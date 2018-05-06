using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class RomeNumbers : ICodeWars
    {
        public object Start()
        {
            return Solution("MCMXCIV");
        }

        private int Solution(string roman)
        {
            var dic = new Dictionary<char, int>()
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000},
            };

            var res = 0;
            for (int i = 0; i < roman.Length-1; i++)
            {                
                if(dic[roman[i]] < dic[roman[i+1]])
                    res -= dic[roman[i]];
                else 
                    res += dic[roman[i]];             
            }

            return res += dic[roman[roman.Length-1]];
        }

        private int Solution2(string roman)
        {
            var res = 0;
            Replace49(ref roman, ref res);     
            return ReplaceRoman(roman, res);
        }

        private void Replace49(ref string roms, ref int res)
        {
            var dic = new Dictionary<string, int>()
            {
                {"IV", 4}, {"IX", 9}, {"XL", 40},
                {"XC", 90}, {"CX", 400}, {"CM", 900},                
            };
            
            foreach (var key in dic.Keys)
            {
                if (roms.Contains(key)) 
                {
                    res += dic[key];
                    roms = roms.Replace(key, "");
                }
            }
        }

        private int ReplaceRoman(string roms, int res)
        {
            var dic = new Dictionary<char, int>()
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000},
            };
            
            res += roms.Sum(i => dic[i]);            
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars
{
    public class SumStringsAsNumbers : ICodeWars
    {
        public object Start()
        {
            return Func("-789", "987");
        }

        private static string Func(string a, string b)
        {
            var isNegativeA = a.StartsWith("-");
            var isNegativeB = b.StartsWith("-");
            var A = a.Length >= b.Length ? (a[0] > b[0] ? a : b)
                                         : b;
            var B = A == a ? b : a; 
            var res = new List<int>();
            
            A.Replace("-","").Reverse();
            B.Replace("-","").Reverse();
            var temp = 0;

            for(int i = A.Length - 1; i >= 0; i--)
            {
                var numA = (int)char.GetNumericValue(A[i]);
                var numB = (int)char.GetNumericValue(B[i]);
                if((isNegativeA && isNegativeB) || (!isNegativeA && !isNegativeB))
                {
                    var num = numA + numB;                                 
                    res.Add(num%10 + temp);
                    temp = num/10;
                }
                else
                {
                    numA = temp == 1 ? numA - 1  : numA;
                    temp = numA > numB ? 0 : 1;
                    var num = (numA + temp * 10) - numB;
                }
            }

            res.Add(temp);
            res.Reverse();
            return string.Concat(res);
        }

        private static string Func2(string a, string b)
        {
            var isNegativeA = a.StartsWith("-");
            var isNegativeB = b.StartsWith("-");

            if((isNegativeA && isNegativeB) || (!isNegativeA && !isNegativeB))
            {
                return (Convert.ToUInt64(a) + Convert.ToUInt64(b)).ToString();
            }
            else if(isNegativeA && !isNegativeB) 
            {
                return (Convert.ToUInt64(b) - Convert.ToUInt64(a.Replace("-",""))).ToString();
            }
            else if(!isNegativeA && isNegativeB)            
            {
                return (Convert.ToUInt64(a) - Convert.ToUInt64(b.Replace("-",""))).ToString();
            }            
            
            return null;            
        }
    }
}
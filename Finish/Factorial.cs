
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Codewars
{
    public class Factorial : ICodeWars<int, string>
    {        
        public string Func(int n)
        {     
            string r = n.ToString();
            n--;
            while(n > 1)
            {
                r = ColumnMultiplication(r, n.ToString());               
                n--;
            }

            return r;
        }

        //multiplication in a column
        public string ColumnMultiplication(string num, string fact)
        {          
            var result = new List<char>();            
            int keepInMind = 0;            
                        
            //i - Index of main number position
            for (int i = num.Length - 1; i > -fact.Length; i--)
            {     
                int sum = 0;

                //y - Index of factorial number position
                //k - Additional index for correcting bias
                for (int y = fact.Length - 1, k = 0; 
                     y >= 0 && k + i < num.Length; 
                     y--, k++)
                {
                    if(k + i < 0) continue;

                    var n1 = char.GetNumericValue(num[i + k]);
                    var n2 = char.GetNumericValue(fact[y]);

                    sum += (int)n1 * (int)n2;
                }          

                sum += keepInMind;               
                keepInMind = sum / 10;
                
                result.Add((sum % 10).ToString()[0]);      
            }

            if(keepInMind > 0) result.Add(keepInMind.ToString()[0]);     
      
            result.Reverse();
            return new string(result.ToArray());
        }
    

        public object Start()
        {
            return Func(100);
        }
    }
}
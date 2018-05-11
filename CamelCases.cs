using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public class CamelCases : ICodeWars
    {
        public object Start()
        {
            return Func(" adsf  as   dfasd fasd f ");
        }

        private string Func(string str)
        {
            var arr = str.Split(' ');
            var sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == "") continue;
                var ns = arr[i].ToCharArray();
                ns[0] = Char.ToUpper(ns[0]);
                sb.Append(new string(ns));
            };
            return sb.ToString();

            // var res = new List<char>();
            // for (int i = 0; i < str.Length; i++)
            // {                
            //     if (str[i] == ' ')
            //     {                    
            //         while (str[i] == ' ')
            //         {
            //             i++;                        
            //         };

            //         res.Add(Char.ToUpper(str[i]));
            //         continue;
            //     }

            //     if (i == 0)
            //     {
            //         res.Add(Char.ToUpper(str[i]));
            //         continue;
            //     }

            //     res.Add(str[i]);
            // }
            // return string.Concat(res);
        }
    }
}
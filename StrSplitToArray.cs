using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codewars
{
    class StrSplitToArray : ICodeWars
    {
        
        object ICodeWars.Start()
        {
            return Func("Hello");
        }

        string Func(string s)
        {  
           
            var res = Regex.Split(s.Length % 2 == 0 ? s : s + "_", "(.{2})").Where(i => !string.IsNullOrEmpty(i)).ToArray();
            return null;
        }
    }
}

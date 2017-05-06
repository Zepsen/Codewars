
using System;
using System.Linq;
using System.Collections.Generic;

public class Wave : ICodeWars
{
    object ICodeWars.Start()
    {
        return Func("he llo");
    }

    public static string Func(string s)
    {     
        var res = s
        .Select((e,i) => 
        {
            var str = s.ToCharArray();
            str[i] = char.ToUpper(e);
            return new string(str);
        })
        .Where(i => i != s)
        .ToArray();  
        return "null";      
    } 
} 
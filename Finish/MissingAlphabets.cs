using System;
using System.Linq;
using System.Collections.Generic;

public class MissingAlphabets : ICodeWars
{
    object ICodeWars.Start()
    {
        return MissingAlphabets.Func("abbccddeeffgg");
    }

    public static string Func(string s)
    {       
        var DIC = "abcdefghijklmnopqrstuvwxyz".ToDictionary(c => c, count => 0);
        var max = s.Select(i => ++DIC[i]).Max(); 
        return string.Join("", DIC.Where(i => i.Value < max).Select(i => new string(i.Key, max - i.Value)));         
    }
}
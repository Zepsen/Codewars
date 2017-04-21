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
        var ABC = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        var DIC = ABC.ToDictionary(c => c, count => 0);
        var res = s.Select(i => DIC[i]++);       
                
        return "asd";
    }
}
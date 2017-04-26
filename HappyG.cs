using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class HappyG : ICodeWars
{
    object ICodeWars.Start()
    {
        var res1 = HappyG.Func("gg0gg3gg0gg");
        var res2 = HappyG.Func("gog");
        var res3 = HappyG.Func("ggg ggg g ggg");
        var res4 = HappyG.Func("A half of a half is a quarter.");
        var res5 = HappyG.Func("good grief");
        var res6 = HappyG.Func("bigger is ggooder");
        var res7 = HappyG.Func("gg0gg3gg0gg");
        var res8 = HappyG.Func("gggggggggg");
        return res1 && res2 && res3 && res4 && res5 && res6 && res7 && res8;
    }

    public static bool Func(string s)
    {        
        var res = !Regex.IsMatch(s, "([^g]|^())g([^g*]|()$)");
        return res;
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

public class FindOddInt : ICodeWars
{
    public object Start()
    {
        return Func(new [] {1,1,2,2,3,3,5});
    }

    public static int Func(int[] seq)
    {       
        var res = seq.GroupBy(i => i).Select(i => new { Key = i.Key, Value = i.Count()}).Single(i => i.Value % 2 != 0);    
                
        return 0;
    }
}
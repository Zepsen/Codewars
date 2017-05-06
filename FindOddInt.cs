using System;
using System.Linq;
using System.Collections.Generic;

public class FindOddInt : ICodeWars
{
    object ICodeWars.Start()
    {
        return Func(new [] {1,1,2,2,3,3,5});
    }

    public static int Func(int[] seq)
    {       
        var res = seq.ToDictionary(i => i, i => 0);
        return 0;
    }
}
using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace Codewars
{
    public class NumbersInStrings : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func("sfd2asdf123wad1234");
        }

        private int Func(string str)
            => new Regex("\\d+", RegexOptions.IgnoreCase)
                   .Matches(str)
                   .Cast<Match>()
                   .Select(i => Convert.ToInt32(i.Value))                   
                   .Max();                          
        
    }
}
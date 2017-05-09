using System;
using System.Text.RegularExpressions;


namespace Codewars
{
    class CountSmileys : ICodeWars
    {
        public object Start()
        {
            var smileys = new string[] { ":D", ":~)", ";~D", ":)" };
            return Func(smileys);
        }

        private static int Func(string[] smileys)
        {
            var pattern = @"[:;]{1}[-~]?[D)]{1}";
            var str = string.Join(",", smileys);
            return Regex.Matches(str, pattern).Count;
        }
    }
}
using System;

namespace Codewars
{
    class Middle : ICodeWars
    {
        public object Start()
        {
            return GetTheMiddle("abcv");
        }

        public static string GetTheMiddle(string s)
        {            
            return s.Substring((s.Length + 1) / 2 - 1, (s.Length - 1) % 2 + 1);
        }
    }
}

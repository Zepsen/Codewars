using System;
using System.Linq;

namespace Codewars
{
    public class Mumbling : ICodeWars
    {
        public object Start()
        {
            return Accum();
        }

        private static string Accum()
        {
            var test = "AcaNmAb";
            var str = string.Join("-", test.Select((el, i) => Char.ToUpper(el) + new string(Char.ToLower(el), i+1)));            
            return str;

        }
    }
}

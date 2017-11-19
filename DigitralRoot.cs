using System;
using System.Linq;

namespace Codewars
{
    public class DigitalRoot : ICodeWars
    {
        object ICodeWars.Start()
        {
            return Func(1234567890);            
        }

        int Func(long n)
        {
            var res = n.ToString().ToList().Sum(i => (int)Char.GetNumericValue(i));
            if(res<10) return res; 
            return Func(res);  
        }
    }
}
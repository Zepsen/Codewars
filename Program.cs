using System;

namespace Codewars
{    
    class Program
    {
        static void Main(string[] args)
        {
            ICodeWars war = new ValidateBraces();
            var res = war.Start();
            Console.WriteLine(res.ToString());
        }
    }    
    
}

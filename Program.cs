using System;

namespace Codewars
{    
    class Program
    {
        static void Main(string[] args)
        {
            ICodeWars war = new MultiplyInt3or5();
            var res = war.Start();
          Console.WriteLine(res.ToString());
        }
    }    
    
}

using System;

namespace Codewars
{    
    /// <summary>
    /// Entry point
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ICodeWars war = new BouncingBalls();
            var res = war.Start();
            Console.WriteLine(res.ToString());
        }
    }    
    
    
}

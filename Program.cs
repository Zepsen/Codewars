using System;
using System.Diagnostics;

namespace Codewars
{    
    /// <summary>
    /// Entry point
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            ICodeWars war = new Factorial();

            s.Start();
            var res = war.Start();
            s.Stop();

            Console.WriteLine($"Result: {res.ToString()}");
            Console.WriteLine($"Execute time: {s.Elapsed}");
        }
    }           
}

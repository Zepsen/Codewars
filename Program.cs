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

            s.Start();
<<<<<<< HEAD
                ICodeWars war = new UniqueNumbers();
                var res = war.Start();
=======
                ICodeWars war = new RomeNumbers();
                var res = war.Start();  
>>>>>>> c719013c62b85e4ed26f6642e25bc1d5f5bd3191
            s.Stop();
            
            Console.WriteLine($"Result: {res.ToString()}");
            Console.WriteLine($"Execute time: {s.Elapsed}");
        }
    }    
    
    class P{
        int a = 0;
        int Foo()
        {
            a = a + 42;
            return 1;
        }
        void Main()
        {
            a = a + Foo(); 
            Console.WriteLine(a);
        }
    }
}

using System;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            ICodeWars war = new Darts();
            var res = war.Start();
            Console.WriteLine(res.ToString());
        }
    }
}
